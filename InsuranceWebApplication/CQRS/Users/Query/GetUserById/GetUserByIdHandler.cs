﻿using AutoMapper;
using InsuranceWebApplication.CQRS.Users.ViewModel;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using MediatR;

namespace InsuranceWebApplication.CQRS.Users.Query.GetUserById
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, UserViewModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetUserByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UserViewModel> Handle(GetUserByIdQuery query, CancellationToken cancel)
        {
            User? user = await _unitOfWork.UserRepository.GetByIdAsync(query.Id, cancel);
            if (user is null)
            {
                throw new Exception($"The user with Id {query.Id} does not exist");
            }
            return _mapper.Map<UserViewModel>(user);
        }
    }
}
