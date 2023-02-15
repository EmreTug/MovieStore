using FluentValidation;
using MovieStore.Application.ActorOperations.Commands.CreateActor;

namespace MovieStore.Application.ActorOperations.Validator
{
    public class CreateActorCommandValidator : AbstractValidator<CreateActorCommand>
    {
        public CreateActorCommandValidator()
        {
            RuleFor(a => a.Model.Name).NotEmpty();
            RuleFor(a => a.Model.LastName).NotEmpty();
            RuleFor(a => a.Model.PlayedMovies).NotEmpty();
        }
    }
}
