using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Password)
                .NotNull()
                .NotEmpty()
                .WithMessage("Id should not be null.");
            RuleFor(x => x.Password)
                .MinimumLength(5)
                .WithMessage("Password size should be bigger than 5.");
            RuleFor(x => x.Username)
                .MinimumLength(3)
                .WithMessage("Username should be bigger than 3");
            RuleFor(x => x.isActive)
                .NotEmpty()
                .NotNull()
                .WithMessage("Active cannot be null or empty.");
        }
    }
}
