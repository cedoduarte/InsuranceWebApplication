using AutoMapper;
using InsuranceWebApplication.CQRS.Users.ViewModel;
using InsuranceWebApplication.Dtos;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using MediatR;

namespace InsuranceWebApplication.CQRS.Users.Query.GetUserList
{
    public class GetUserListHandler : IRequestHandler<GetUserListQuery, UserListResultDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetUserListHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UserListResultDto> Handle(GetUserListQuery query, CancellationToken cancel)
        {
            List<User>? userList = null;
            var result = new UserListResultDto();

            result.TotalCount = await _unitOfWork.UserRepository.CountAsync(cancel);
            if (query.GetAll)
            {
                userList = await _unitOfWork.UserRepository.GetAllAsync(query.PageNumber, query.PageSize, cancel);
                result.UserList = _mapper.Map<List<UserViewModel>>(userList);
                return result;
            }

            if (string.IsNullOrEmpty(query.Keyword))
            {
                throw new Exception("The keyword is empty");
            }

            string keyword = query.Keyword.ToLower().Trim();
            userList = await _unitOfWork.UserRepository.GetByKeywordAsync(keyword, query.PageNumber, query.PageSize, cancel);
            result.UserList = _mapper.Map<List<UserViewModel>>(userList);
            return result;
        }
    }
}