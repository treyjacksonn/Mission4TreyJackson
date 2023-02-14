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

        public DbSet<movieEntry> Movies { get;set; }
    }
}
