using MovieListDotnetMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace MovieListDotnetMVC.DatabaseContext
{
    public class MovieDbInitializer : DropCreateDatabaseIfModelChanges<MovieDbContext>
    {
        Category horror;
        Category romance;
        Category fantasy;

        protected override void Seed(MovieDbContext context)
        {
            context.Categories.AddOrUpdate(
                n => n.Name,
                horror = new Category
                {
                    Name = "Horror"
                },
                romance = new Category
                {
                    Name = "Romance"
                },
                fantasy = new Category
                {
                    Name = "Fantasy"
                }
                );

            context.Movies.AddOrUpdate(
                x => x.Title,
                new Movie
                {
                    Title = "A Nightmare on Elm Street",
                    Year = 1984,
                    Description = "The monstrous spirit of a slain child murderer seeks revenge by invading the dreams of teenagers whose parents were responsible for his untimely death.",
                    Rating = 76,
                    Category = horror
                },
                new Movie
                {
                    Title = "Alfie",
                    Year = 2004,
                    Description = "A cockney womanizer learns the hard way about the dangers of his actions.",
                    Rating = 49,
                    Category = romance
                },
                new Movie
                {
                    Title = "Avatar",
                    Year = 2009,
                    Description = "A paraplegic Marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home.",
                    Rating = 83,
                    Category = fantasy
                }
                );
        }
    }
}