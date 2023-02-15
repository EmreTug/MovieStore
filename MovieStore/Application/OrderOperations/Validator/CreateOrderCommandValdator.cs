using FluentValidation;
using MovieStore.Application.OrderOperations.Commands.CreateOrder;

namespace MovieStore.Application.OrderOperations.Validator
{
    public class CreateOrderCommandValdator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValdator()
        {
            RuleFor(o => o.Model.MovieId).NotEmpty();
            RuleFor(o => o.Model.CustomerId).NotEmpty();
           
        }
    }
}
