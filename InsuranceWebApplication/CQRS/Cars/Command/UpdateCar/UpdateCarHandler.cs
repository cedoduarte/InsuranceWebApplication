﻿using AutoMapper;
using InsuranceWebApplication.CQRS.Cars.Validators;
using InsuranceWebApplication.CQRS.Cars.ViewModel;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using MediatR;
using System.Text;

namespace InsuranceWebApplication.CQRS.Cars.Command.UpdateCar
{
    public class UpdateCarHandler : IRequestHandler<UpdateCarCommand, CarViewModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IUpdateCarCommandValidator _validator;

        public UpdateCarHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IUpdateCarCommandValidator validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<CarViewModel> Handle(UpdateCarCommand command, CancellationToken cancel)
        {
            _validator.Validate(command);
            if (_validator.Errors.Any())
            {
                StringBuilder builder = new StringBuilder();
                foreach (string error in _validator.Errors)
                {
                    builder.AppendLine($"{error}</br>");
                }
                throw new Exception(builder.ToString());
            }
            Car? car = await _unitOfWork.CarRepository.GetByIdAsync(command.Id, cancel);
            if (car is null)
            {
                throw new Exception($"The car with Id {command.Id} does not exist");
            }
            car.Model = command.Model!.Trim();
            car.Color = command.Color!.Trim();
            car.Price = command.Price;
            car.PlateNumber = command.PlateNumber;
            car.LastModified = DateTime.UtcNow;
            Car? updatedCar = await _unitOfWork.CarRepository.UpdateAsync(car, cancel);
            if (updatedCar is null)
            {
                throw new Exception("Error updating the car");
            }
            return _mapper.Map<CarViewModel>(updatedCar);
        }
    }
}
