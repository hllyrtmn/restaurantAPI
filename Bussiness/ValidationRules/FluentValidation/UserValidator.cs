﻿using Business.Constant;
using Core.Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage(Messages.UserFirstNameNotEmpty);
            RuleFor(c => c.FirstName).MinimumLength(3).WithMessage(Messages.UserFirstNameMinimumLength);

            RuleFor(u => u.LastName).NotEmpty().WithMessage(Messages.UserLastNameNotEmpty);
            RuleFor(c => c.LastName).MinimumLength(3).WithMessage(Messages.UserFirstNameMinimumLength);

            RuleFor(u => u.Email).NotEmpty().WithMessage(Messages.UserEmailNotEmpty);
            RuleFor(c => c.Email).MinimumLength(3).WithMessage(Messages.UserFirstNameMinimumLength);
            RuleFor(c => c.Email).EmailAddress().WithMessage(Messages.UserEmailAddress);

        }

    }
}