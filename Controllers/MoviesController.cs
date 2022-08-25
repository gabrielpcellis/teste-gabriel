using ApiTeste.Entities;
using ApiTeste.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTeste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        // GET: api/<MoviesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MoviesController>/5
        [HttpGet("list")]
        public async Task<ActionResult> GetList(int skip = 0, int take = 20)
        {
            var movies = MoviesService.CreateMoviesList();

            var list = movies.Skip(skip).Take(take);

            return Ok(list);
        }

        // GET api/<MoviesController>/5
        [Authorize(Roles = "employee, manager")]
        [HttpGet("listByName")]
        public async Task<ActionResult> GetListByName([FromQuery(Name = "firstLetters")] string letters)
        {
            var movieList = new List<Movies>();

            var movies = MoviesService.CreateMoviesList();

            foreach (var movie in movies.Where(x => x.Name.StartsWith(letters)))
                movieList.Add(movie);

            return Ok(movieList.Take(20));
        }

        // GET api/<MoviesController>/5
        [Authorize(Roles = "manager")]
        [HttpGet("{id}")]
        public Movies GetById(int id)
        {
            var mov = new Movies();

            var movies = MoviesService.CreateMoviesList();

            foreach (var movie in movies.Where(x => x.Id == id))
                mov = movie;

            return mov;
        }

        // POST api/<MoviesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MoviesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
