using FluentValidation;
using Shared.Entities;

namespace Shared.Validators
{
    public class EntityValidator : AbstractValidator<Entity>
    {
        public EntityValidator()
        {
            RuleFor(x => x.Id).NotNull().NotEmpty();
            RuleFor(x => x.CreatedAt).NotNull().NotEmpty();
        }
    }
}
