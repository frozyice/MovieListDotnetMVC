using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieListDotnetMVC.Models
{
    public class MoviesList
    {
        public ICollection<Movie> Movies { get; set; }

        public MoviesList(ICollection<Movie> movies)
        {
            Movies = movies;
        }
    }
}