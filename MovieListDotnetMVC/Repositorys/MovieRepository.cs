using MovieListDotnetMVC.DatabaseContext;
using MovieListDotnetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieListDotnetMVC.Repositorys
{
    public class MovieRepository
    {
        private MovieDbContext db = new MovieDbContext();

        public MoviesList ListOfMovies()
        {
            MoviesList moviesList = new MoviesList(db.Movies.OrderBy(x => x.Title).ToList());
            return moviesList;
        }
        
        public Movie DetailsOfMovie(Guid id)
        {
            Movie movie = db.Movies.Find(id);
            return movie;
        }
        
    }
}