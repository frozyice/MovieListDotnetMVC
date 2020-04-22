using MovieListDotnetMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MovieListDotnetMVC.DatabaseContext
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext() : base("Movies")
        {
            Database.SetInitializer(new MovieDbInitializer());
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}