using FluentValidation;
using MovieStore.Application.MovieOperations.Commands;

namespace MovieStore.Application.MovieOperations.Validator
{
    public class UpdateMovieCommandValidator : AbstractValidator<UpdateMovieCommand>
    {
        public UpdateMovieCommandValidator()
        {
            RuleFor(m => m.Model.Title).NotEmpty().MinimumLength(2);
            RuleFor(m => m.Model.Price).NotEmpty().GreaterThan(0);
            RuleFor(m => m.Model.GenreID).NotEmpty().GreaterThan(0);
            RuleFor(m => m.Model.Year).NotEmpty().MinimumLength(4).MaximumLength(4);
            RuleFor(m => m.Model.Actors).NotEmpty().MinimumLength(2);
            RuleFor(m => m.Model.Director).NotEmpty().MinimumLength(2);
        }
    }
}
