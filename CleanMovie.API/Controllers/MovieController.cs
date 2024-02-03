using CleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService; // This assigns the injected service to the field
        }


        // GET: api/<MovieController>
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var MovieFromService = _movieService.GetAllMovies();
            return Ok(MovieFromService);
        }

        
    }
}
