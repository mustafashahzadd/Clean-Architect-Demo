using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository movie_repository;
        //Constuctor Dependency injection
        public MovieService(IMovieRepository movie_repository)
        {
            this.movie_repository = movie_repository;
        }

        public List<Movie> GetAllMovies()
        {
           var movies= movie_repository.GetAllMovies();
            return movies;
        }
    }
}
