using Microsoft.AspNetCore.Mvc;
using modul9_103082400029.Models;
using System.Collections.Generic;

namespace modul9_103082400029.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        public static List<Movie> movies = new List<Movie>
        {
            new Movie
            {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string>{ "Tim Robbins", "Morgan Freeman" },
                Description = "Two imprisoned men bond over years."
            },

            new Movie
            {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string>{ "Marlon Brando", "Al Pacino" },
                Description = "Story of mafia family."
            },

            new Movie
            {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new List<string>{ "Christian Bale", "Heath Ledger" },
                Description = "Batman fights Joker."
            }
        };

        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            return movies;
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetById(int id)
        {
            return movies[id];
        }

        [HttpPost]
        public ActionResult Post(Movie movie)
        {
            movies.Add(movie);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            movies.RemoveAt(id);
            return Ok();
        }
    }
}