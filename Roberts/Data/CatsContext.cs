using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Roberts.Models;

namespace Roberts.Data
{
  
        public class CatsContext : DbContext //, IDesignTimeDbContextFactory(EventsContext)
        {

            public CatsContext()
            {

            }


            public CatsContext(DbContextOptions<CatsContext> options) : base(options)
            {

            }



            public DbSet<Cats> Cats { get; set; }

        }
    }
