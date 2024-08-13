﻿using AutoMapper;
using InsuranceWebApplication.CQRS.Users.ViewModel;
using InsuranceWebApplication.Dtos;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using InsuranceWebApplication.Utils;
using MediatR;

namespace InsuranceWebApplication.CQRS.Users.Command.AuthenticateUser
{
    public class AuthenticateUserHandler : IRequestHandler<AuthenticateUserCommand, UserAuthenticationResultDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AuthenticateUserHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UserAuthenticationResultDto> Handle(AuthenticateUserCommand command, CancellationToken cancel)
        {
            if (string.IsNullOrEmpty(command.Email))
            {
                throw new Exception("The email is empty");
            }
            if (string.IsNullOrEmpty(command.Password))
            {
                throw new Exception("The password is empty");
            }
            string passwordHash = Util.ToSha256(command.Password);
            User? user = await _unitOfWork.UserRepository.AuthenticateAsync(command.Email, passwordHash, cancel);
            bool authenticated = user is not null;
            return new UserAuthenticationResultDto()
            {
                IsAuthenticated = authenticated,
                ErrorMessage = authenticated ? "Authenticated successfully" : "The credentials are invalid",
                AuthenticatedUser = _mapper.Map<UserViewModel>(user)
            };
        }
    }
}
