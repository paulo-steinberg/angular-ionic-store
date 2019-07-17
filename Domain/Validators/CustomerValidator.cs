using Domain.Entities;
using FluentValidation;

namespace Domain.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.FirstName).MinimumLength(3).WithMessage("First Name too short.");
            RuleFor(x => x.LastName).MinimumLength(3).WithMessage("Last Name too short.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Invalid email address");
            RuleFor(x => x.BirthDay).NotEmpty().NotNull().WithMessage("Invalid birthdate");
            RuleFor(x => x.User).NotEmpty().NotNull().WithMessage("Invalid user");
        }
    }
}
