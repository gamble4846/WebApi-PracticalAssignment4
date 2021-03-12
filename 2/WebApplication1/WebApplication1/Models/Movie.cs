using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace WebApplication1.Models
{
    public class Movie
    {
        // ( movie_id, movie_name, movie_cast)
        public int movie_id { get; set; }
        public String movie_name { get; set; }
        public String movie_cast { get; set; }
    }
}