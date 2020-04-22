using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieListDotnetMVC.Models
{
    public class Movie
    {
        public Guid MovieId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }

        public Category Category { get; set; }

        public Movie()
        {
            MovieId = Guid.NewGuid();
        }
    }

}