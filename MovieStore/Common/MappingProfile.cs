using AutoMapper;
using MovieStore.Application.ActorOperations.Commands.CreateActor;
using MovieStore.Application.ActorOperations.Querys.GetListActor;
using MovieStore.Application.CustomerOperations.Commands.CreateCustomer;
using MovieStore.Application.DirectorOperations.Commands.CreateDirector;
using MovieStore.Application.DirectorOperations.Commands.UpdateDirector;
using MovieStore.Application.DirectorOperations.Queries.GetByIdDirector;
using MovieStore.Application.DirectorOperations.Queries.GetListDirector;
using MovieStore.Application.GenreOperations.Commands;
using MovieStore.Application.GenreOperations.Querys;
using MovieStore.Application.MovieOperations.Commands;
using MovieStore.Application.MovieOperations.Querys;
using MovieStore.Application.OrderOperations.Model;
using MovieStore.Entities;

namespace MovieStore.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Movei
            CreateMap<Movie, MovieViewModel>()
            .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name));

            CreateMap<Movie, MovieDetailModel>()
            .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name));

            CreateMap<Movie, CreateMovieModel>().ReverseMap();

           
            CreateMap<UpdateMoveiModel, Movie>().ReverseMap();

            //Genre

            CreateMap<Genre , GetListModel>().ReverseMap();
            
            CreateMap<Genre, GenreDetailModel>().ReverseMap();
           

            CreateMap<CreateGenreModel, Genre >().ReverseMap();

            CreateMap<UpdateGenreModel, Genre >().ReverseMap();

            //Customer 
            CreateMap<Customer, CreateCustomerModel>().ReverseMap();

            //Actor
            CreateMap<Actor, CreateActorModel>().ReverseMap();

            CreateMap<Actor, GetListActorModel>().ReverseMap();


            //Director
            CreateMap<Director, CreateDirectorModel>().ReverseMap();

            CreateMap<Director, UpdateDirectorModel>().ReverseMap();

            CreateMap<Director, GetListDirectorModel>().ReverseMap();

            CreateMap<Director, GetByIdDirectorModel>().ReverseMap();


            //Order
            CreateMap<CreateOrderModel, Order>().ReverseMap();
            CreateMap<UpdateOrderModel, Order>().ReverseMap();

            CreateMap<Customer, OrderViewModel>()
                .ForMember(dest => dest.NameSurname, opt => opt.MapFrom(m => m.Name + " " + m.LastName))
                .ForMember(dest => dest.Movies, opt => opt.MapFrom(m => m.Orders.Select(s => s.Movie.Title)))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(m => m.Orders.Select(s => s.Movie.Price)))
                .ForMember(dest => dest.PurchasedDate, opt => opt.MapFrom(m => m.Orders.Select(s => s.purchasedTime)));




        }
    }
}
