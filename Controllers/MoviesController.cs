using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
//using Canducci.Pagination;
using System.Threading.Tasks;
using ApiTeste.Entities;
using ApiTeste.Service;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
            var movies = new List<Movies>()
            {
                new Movies{
                Id = 0,
                Name = "Um sonho de Liberdade",
                Gender = "Ação"
                },
                new Movies{
                Id = 1,
                Name = "O Poderoso Chefão ",
                Gender = "Ação"
                },
                new Movies{
                Id = 2,
                Name = "O Poderoso Chefão 2",
                Gender = "Ação"
                },
                new Movies{
                Id = 3,
                Name = "Batman - O Cavaleiro das Trevas",
                Gender = "Ação"
                },
                new Movies{
                Id = 4,
                Name = "12 Homens e uma Sentença",
                Gender = "Ação"
                },
                new Movies{
                Id = 5,
                Name = "A Lista de Schindler",
                Gender = "Ação"
                },
                new Movies{
                Id = 6,
                Name = "Pulp Fiction: Tempo de Violência",
                Gender = "Ação"
                },
                new Movies{
                Id = 7,
                Name = "O Senhor dos Anéis: O Retorno do Rei",
                Gender = "Ação"
                },
                new Movies{
                Id = 8,
                Name = "Três homens em Conflito",
                Gender = "Ação"
                },
                new Movies{
                Id = 9,
                Name = "Clube da Luta",
                Gender = "Ação"
                },
                new Movies{
                Id = 10,
                Name = "Inception",
                Gender = "Ação"
                },
                new Movies{
                Id = 11,
                Name = "O Senhor dos Anéis: A Sociedade do Anel",
                Gender = "Ação"
                },
                new Movies{
                Id = 12,
                Name = "Os Bons Companheiros",
                Gender = "Ação"
                },
                new Movies{
                Id = 13,
                Name = "Matrix",
                Gender = "Ação"
                },
                new Movies{
                Id = 14,
                Name = "Os Sete Samurais",
                Gender = "Ação"
                },
                new Movies{
                Id = 15,
                Name = "Cidade de Deus",
                Gender = "Ação"
                },
                new Movies{
                Id = 16,
                Name = "A Vida é Bela",
                Gender = "Ação"
                },
                new Movies{
                Id = 17,
                Name = "O Silêncio dos Inocentes",
                Gender = "Ação"
                },
                new Movies{
                Id = 18,
                Name = "Pulp Fiction: Tempo de Violência",
                Gender = "Ação"
                },
                new Movies{
                Id = 19,
                Name = "O Senhor dos Anéis: O Retorno do Rei",
                Gender = "Ação"
                },
                new Movies{
                Id = 20,
                Name = "Três homens em Conflito",
                Gender = "Ação"
                },
                new Movies{
                Id = 21,
                Name = "Um sonho de Liberdade",
                Gender = "Ação"
                },
                new Movies{
                Id = 22,
                Name = "O Poderoso Chefão ",
                Gender = "Ação"
                },
                new Movies{
                Id = 23,
                Name = "O Poderoso Chefão 2",
                Gender = "Ação"
                },
                new Movies{
                Id = 24,
                Name = "Batman - O Cavaleiro das Trevas",
                Gender = "Ação"
                },
                new Movies{
                Id = 25,
                Name = "12 Homens e uma Sentença",
                Gender = "Ação"
                },
                new Movies{
                Id = 26,
                Name = "A Lista de Schindler",
                Gender = "Ação"
                },
                new Movies{
                Id = 27,
                Name = "Pulp Fiction: Tempo de Violência",
                Gender = "Ação"
                },
                new Movies{
                Id = 28,
                Name = "O Senhor dos Anéis: O Retorno do Rei",
                Gender = "Ação"
                },
                new Movies{
                Id = 29,
                Name = "Três homens em Conflito",
                Gender = "Ação"
                },
                new Movies{
                Id = 30,
                Name = "Clube da Luta",
                Gender = "Ação"
                },
                new Movies{
                Id = 31,
                Name = "Inception",
                Gender = "Ação"
                },
                new Movies{
                Id = 32,
                Name = "O Senhor dos Anéis: A Sociedade do Anel",
                Gender = "Ação"
                },
                new Movies{
                Id = 33,
                Name = "Os Bons Companheiros",
                Gender = "Ação"
                },
                new Movies{
                Id = 34,
                Name = "Matrix",
                Gender = "Ação"
                },
                new Movies{
                Id = 35,
                Name = "Os Sete Samurais",
                Gender = "Ação"
                },
                new Movies{
                Id = 36,
                Name = "Cidade de Deus",
                Gender = "Ação"
                },
                new Movies{
                Id = 37,
                Name = "A Vida é Bela",
                Gender = "Ação"
                },
                new Movies{
                Id = 38,
                Name = "O Silêncio dos Inocentes",
                Gender = "Ação"
                },
                new Movies{
                Id = 39,
                Name = "Pulp Fiction: Tempo de Violência",
                Gender = "Ação"
                },
                new Movies{
                Id = 40,
                Name = "O Senhor dos Anéis: O Retorno do Rei",
                Gender = "Ação"
                },
                new Movies{
                Id = 41,
                Name = "Três homens em Conflito",
                Gender = "Ação"
                }
            };

            var list = movies.Skip(skip).Take(take);

            return Ok(list);
        }

        // GET api/<MoviesController>/5
        [HttpGet("listByName")]
        public async Task<ActionResult> GetListByName([FromQuery(Name = "firstLetters")] string letters)
        {
            var movieList = new List<Movies>();

            var movies = new List<Movies>()
            {
                new Movies{
                Id = 0,
                Name = "Um sonho de Liberdade",
                Gender = "Ação"
                },
                new Movies{
                Id = 1,
                Name = "O Poderoso Chefão ",
                Gender = "Ação"
                },
                new Movies{
                Id = 2,
                Name = "O Poderoso Chefão 2",
                Gender = "Ação"
                },
                new Movies{
                Id = 3,
                Name = "Batman - O Cavaleiro das Trevas",
                Gender = "Ação"
                },
                new Movies{
                Id = 4,
                Name = "12 Homens e uma Sentença",
                Gender = "Ação"
                },
                new Movies{
                Id = 5,
                Name = "A Lista de Schindler",
                Gender = "Ação"
                },
                new Movies{
                Id = 6,
                Name = "Pulp Fiction: Tempo de Violência",
                Gender = "Ação"
                },
                new Movies{
                Id = 7,
                Name = "O Senhor dos Anéis: O Retorno do Rei",
                Gender = "Ação"
                },
                new Movies{
                Id = 8,
                Name = "Três homens em Conflito",
                Gender = "Ação"
                },
                new Movies{
                Id = 9,
                Name = "Clube da Luta",
                Gender = "Ação"
                },
                new Movies{
                Id = 10,
                Name = "Inception",
                Gender = "Ação"
                },
                new Movies{
                Id = 11,
                Name = "O Senhor dos Anéis: A Sociedade do Anel",
                Gender = "Ação"
                },
                new Movies{
                Id = 12,
                Name = "Os Bons Companheiros",
                Gender = "Ação"
                },
                new Movies{
                Id = 13,
                Name = "Matrix",
                Gender = "Ação"
                },
                new Movies{
                Id = 14,
                Name = "Os Sete Samurais",
                Gender = "Ação"
                },
                new Movies{
                Id = 15,
                Name = "Cidade de Deus",
                Gender = "Ação"
                },
                new Movies{
                Id = 16,
                Name = "A Vida é Bela",
                Gender = "Ação"
                },
                new Movies{
                Id = 17,
                Name = "O Silêncio dos Inocentes",
                Gender = "Ação"
                },
                new Movies{
                Id = 18,
                Name = "Pulp Fiction: Tempo de Violência",
                Gender = "Ação"
                },
                new Movies{
                Id = 19,
                Name = "O Senhor dos Anéis: O Retorno do Rei",
                Gender = "Ação"
                },
                new Movies{
                Id = 20,
                Name = "Três homens em Conflito",
                Gender = "Ação"
                },
                new Movies{
                Id = 21,
                Name = "Um sonho de Liberdade",
                Gender = "Ação"
                },
                new Movies{
                Id = 22,
                Name = "O Poderoso Chefão ",
                Gender = "Ação"
                },
                new Movies{
                Id = 23,
                Name = "O Poderoso Chefão 2",
                Gender = "Ação"
                },
                new Movies{
                Id = 24,
                Name = "Batman - O Cavaleiro das Trevas",
                Gender = "Ação"
                },
                new Movies{
                Id = 25,
                Name = "12 Homens e uma Sentença",
                Gender = "Ação"
                },
                new Movies{
                Id = 26,
                Name = "A Lista de Schindler",
                Gender = "Ação"
                },
                new Movies{
                Id = 27,
                Name = "Pulp Fiction: Tempo de Violência",
                Gender = "Ação"
                },
                new Movies{
                Id = 28,
                Name = "O Senhor dos Anéis: O Retorno do Rei",
                Gender = "Ação"
                },
                new Movies{
                Id = 29,
                Name = "Três homens em Conflito",
                Gender = "Ação"
                },
                new Movies{
                Id = 30,
                Name = "Clube da Luta",
                Gender = "Ação"
                },
                new Movies{
                Id = 31,
                Name = "Inception",
                Gender = "Ação"
                },
                new Movies{
                Id = 32,
                Name = "O Senhor dos Anéis: A Sociedade do Anel",
                Gender = "Ação"
                },
                new Movies{
                Id = 33,
                Name = "Os Bons Companheiros",
                Gender = "Ação"
                },
                new Movies{
                Id = 34,
                Name = "Matrix",
                Gender = "Ação"
                },
                new Movies{
                Id = 35,
                Name = "Os Sete Samurais",
                Gender = "Ação"
                },
                new Movies{
                Id = 36,
                Name = "Cidade de Deus",
                Gender = "Ação"
                },
                new Movies{
                Id = 37,
                Name = "A Vida é Bela",
                Gender = "Ação"
                },
                new Movies{
                Id = 38,
                Name = "O Silêncio dos Inocentes",
                Gender = "Ação"
                },
                new Movies{
                Id = 39,
                Name = "Pulp Fiction: Tempo de Violência",
                Gender = "Ação"
                },
                new Movies{
                Id = 40,
                Name = "O Senhor dos Anéis: O Retorno do Rei",
                Gender = "Ação"
                },
                new Movies{
                Id = 41,
                Name = "Três homens em Conflito",
                Gender = "Ação"
                }
            };

            foreach (var movie in movies.Where(x => x.Name.StartsWith(letters)))
                movieList.Add(movie);

            return Ok(movieList.Take(20));
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
