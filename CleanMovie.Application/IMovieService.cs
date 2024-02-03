using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    
    // This is a use case
    /*
     This Interface is responsible for defining the buisness case and how this cas eis implemented
     */
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
    }
}
