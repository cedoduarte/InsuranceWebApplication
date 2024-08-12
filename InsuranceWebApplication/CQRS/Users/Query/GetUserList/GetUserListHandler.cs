using AutoMapper;
using InsuranceWebApplication.CQRS.Users.ViewModel;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using MediatR;

namespace InsuranceWebApplication.CQRS.Users.Query.GetUserList
{
    public class GetUserListHandler : IRequestHandler<GetUserListQuery, List<UserViewModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetUserListHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<UserViewModel>> Handle(GetUserListQuery query, CancellationToken cancel)
        {
            List<User>? userList = null;
            if (query.GetAll)
            {
                userList = await _unitOfWork.UserRepository.GetAllAsync(cancel);
                return _mapper.Map<List<UserViewModel>>(userList);
            }
            if (string.IsNullOrEmpty(query.Keyword))
            {
                throw new Exception("The keyword is empty");
            }
            string keyword = query.Keyword.ToLower().Trim();
            userList = await _unitOfWork.UserRepository.GetByKeywordAsync(keyword);
            return _mapper.Map<List<UserViewModel>>(userList);
        }
    }
}
