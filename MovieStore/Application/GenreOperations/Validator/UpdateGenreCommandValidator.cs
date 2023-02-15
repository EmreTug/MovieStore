using FluentValidation;
using MovieStore.Application.GenreOperations.Commands;

namespace MovieStore.Application.GenreOperations.Validator
{
    public class UpdateGenreCommandValidator : AbstractValidator<UpdateGenreCommand>
    {
        public UpdateGenreCommandValidator()
        {
            RuleFor(g => g.Model.Name).NotEmpty().MinimumLength(2);
        }
    }
}
