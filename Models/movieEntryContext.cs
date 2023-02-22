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


        // populates the database with these three movies if it is empty
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<movieEntry>().HasData(
                new movieEntry
                {
                    MovieID = 1,
                    Category = "Crime/Drama",
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
                       Category = "War/Drama",
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
                          Category = "Romance",
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
