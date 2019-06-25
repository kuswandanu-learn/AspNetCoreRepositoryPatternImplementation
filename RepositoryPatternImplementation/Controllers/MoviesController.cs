using Microsoft.AspNetCore.Mvc;
using RepositoryPatternImplementation.Data.EFCore;
using RepositoryPatternImplementation.Models;

namespace RepositoryPatternImplementation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : MyMDBController<Movie, EfCoreMovieRepository>
    {
        public MoviesController(EfCoreMovieRepository repository) : base(repository)
        {

        }
    }
}
