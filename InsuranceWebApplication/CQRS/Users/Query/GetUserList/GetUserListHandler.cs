using AutoMapper;
using InsuranceWebApplication.CQRS.Users.ViewModel;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using MediatR;

namespace InsuranceWebApplication.CQRS.Users.Query.GetUserList
{
    public class GetUserListHandler : IRequestHandler<GetUserListQuery, List<UserViewModel>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetUserListHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<UserViewModel>> Handle(GetUserListQuery query, CancellationToken cancel)
        {
            List<User>? userList = null;
            if (query.GetAll)
            {
                userList = await _userRepository.GetAllAsync(cancel);
                return _mapper.Map<List<UserViewModel>>(userList);
            }
            if (string.IsNullOrEmpty(query.Keyword))
            {
                throw new Exception("The keyword is empty");
            }
            string keyword = query.Keyword.ToLower().Trim();
            userList = await _userRepository.GetByKeywordAsync(keyword);
            return _mapper.Map<List<UserViewModel>>(userList);
        }
    }
}
