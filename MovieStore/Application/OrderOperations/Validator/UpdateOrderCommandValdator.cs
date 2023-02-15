using FluentValidation;
using MovieStore.Application.OrderOperations.Commands.UpdateOrder;

namespace MovieStore.Application.OrderOperations.Validator
{
    public class UpdateOrderCommandValdator : AbstractValidator<UpdateOrderCommand>
    {
        public UpdateOrderCommandValdator()
        {

        }
    }
}
