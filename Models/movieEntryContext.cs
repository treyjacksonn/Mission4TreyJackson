using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4TreyJackson.Models
{
    public class movieEntryContext : DbContext
    {
        // constructor
       public movieEntryContext(DbContextOptions<movieEntryContext> options) : base(options) { 
        
         
        }

        public DbSet<movieEntry> movieEntry { get;set; }
        public DbSet<Category> Categories { get; set; }


        
        protected override void OnModelCreating(ModelBuilder mb)
        {
            // populates the Category database with the CategoryIDs along with their corresponding name options.

            mb.Entity<Category>().HasData(

                new Category { CategoryID = 1, CategoryName = "Drama" },
                new Category { CategoryID = 2, CategoryName = "Romance" },
                new Category { CategoryID = 3, CategoryName = "Horror" },
                new Category { CategoryID = 4, CategoryName = "Comedy" },
                new Category { CategoryID = 5, CategoryName = "Documentary" }

            );

            // populates the movieEntry database with these three movies if it is empty

            mb.Entity<movieEntry>().HasData(
                new movieEntry
                {
                    MovieID = 1,
                    CategoryID = 1,
                    Title = "The Godfather",
                    Year = 1972,
                    Director = "Francis Ford Coppola",
                    Rating = "R",
                    Edited = "False",
                    LentTo = "",
                    Notes = "Greatest of all time!"
                },
                   new movieEntry
                   {
                       MovieID = 2,
                       CategoryID = 1,
                       Title = "1917",
                       Year = 2019,
                       Director = "Sam Mendes",
                       Rating = "R",
                       Edited = "True",
                       LentTo = "",
                       Notes = "Favorite War Movie"
                   },
                      new movieEntry
                      {
                          MovieID = 3,
                          CategoryID = 2,
                          Title = "Eternal Sunshine of the Spotless Mind",
                          Year = 2004,
                          Director = "Michel Gondry",
                          Rating = "R",
                          Edited = "False",
                          LentTo = "",
                          Notes = "Favorite Romance"
                      }
                    );
        }
    }
}
