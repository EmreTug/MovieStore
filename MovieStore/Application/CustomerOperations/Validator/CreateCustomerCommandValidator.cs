using FluentValidation;
using MovieStore.Application.CustomerOperations.Commands.CreateCustomer;

namespace MovieStore.Application.CustomerOperations.Validator
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(c => c.Model.Name).NotEmpty();
            RuleFor(c => c.Model.LastName).NotEmpty();
            RuleFor(c => c.Model.Email).NotEmpty();
            RuleFor(c => c.Model.Password).NotEmpty();
        }
    }
}
