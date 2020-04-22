using MovieListDotnetMVC.Models;
using MovieListDotnetMVC.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieListDotnetMVC.Services
{
    public class MovieService : MovieRepository
    {
        private MovieRepository movieRepository = new MovieRepository();

        public MoviesList ListOfMovies()
        {
            MoviesList moviesList = movieRepository.ListOfMovies();
            return moviesList;
        }

        public Movie DetailsOfMovie(Guid id)
        {
            Movie movie = movieRepository.DetailsOfMovie(id);
            return movie;
        }
    }
}