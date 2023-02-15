using FluentValidation;
using MovieStore.Application.DirectorOperations.Commands.CreateDirector;

namespace MovieStore.Application.DirectorOperations.Validator
{
    public class UpdateDirectorCommandValidator : AbstractValidator<CreateDirectorCommand>
    {
        public UpdateDirectorCommandValidator()
        {
            RuleFor(d => d.Model.Name).NotEmpty();
            RuleFor(d => d.Model.LastName).NotEmpty();
            RuleFor(d => d.Model.FilmsDirected).NotEmpty();
        }
    }
}
