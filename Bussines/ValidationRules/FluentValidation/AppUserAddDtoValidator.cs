using Entities.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.ValidationRules.FluentValidation
{
   public class AppUserAddDtoValidator : AbstractValidator<AppUserAddDto>
    {
        public AppUserAddDtoValidator()
        {
            RuleFor(I => I.UserName).NotEmpty().WithMessage("Username cannot be blank.");
            RuleFor(I => I.Password).NotEmpty().WithMessage("Password cannot be blank.");
            RuleFor(I => I.FullName).NotEmpty().WithMessage("Name and surname field cannot be blank.");
        }
    }
}
