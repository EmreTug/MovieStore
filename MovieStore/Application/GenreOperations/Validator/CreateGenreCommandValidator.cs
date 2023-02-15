using FluentValidation;
using MovieStore.Application.GenreOperations.Commands;

namespace MovieStore.Application.GenreOperations.Validator
{
    public class CreateGenreCommandValidator : AbstractValidator<CreateGenreCommand>
    {
        public CreateGenreCommandValidator()
        {
            RuleFor(g => g.Model.Name).NotEmpty().MinimumLength(2);

        }
    }
}
