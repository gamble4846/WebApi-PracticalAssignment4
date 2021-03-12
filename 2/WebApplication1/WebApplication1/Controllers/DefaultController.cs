using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DefaultController : ApiController
    {
        static List<Movie> movies = new List<Movie>();

        [Route("api/addMovie")]
        [HttpPost]
        public String addMovie(String movie_name, String movie_cast)
        {
            Movie obj = new Movie();
            obj.movie_name = movie_name;
            obj.movie_cast = movie_cast;
            obj.movie_id = movies.Count == 0 ? 0 : (movies[movies.Count - 1].movie_id + 1);
            movies.Add(obj);
            return "Movie Added";
        }

        [Route("api/viewMovies")]
        [HttpGet]
        public List<Movie> viewMovies()
        {
            return movies;
        }

        [Route("api/deleteMovie")]
        [HttpPost]
        public String deleteMovie(int movie_id)
        {
            String Movie_Name = "";
            String returnstring;
            bool flag = false;

            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].movie_id == movie_id)
                {
                    Movie_Name = movies[i].movie_name;
                    movies.RemoveAt(i);
                    flag = true;
                }
            }

            returnstring = (flag) ? Movie_Name + " Is Deleted" : "Movie Not Found";

            return returnstring;
        }

        [Route("api/updateMovie")]
        [HttpPost]
        public String updateMovie(int movie_id, String movie_name, String movie_cast)
        {
            String Movie_Name = "";
            String returnstring;
            bool flag = false;

            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].movie_id == movie_id)
                {
                    Movie_Name = movies[i].movie_name = movie_name;
                    movies[i].movie_cast = movie_cast;
                    flag = true;
                }
            }

            returnstring = (flag) ? Movie_Name + " Is Updated" : "Movie Not Found";
            return returnstring;
        }
    }
}
