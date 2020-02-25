using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreKurs_Berlin.Data
{
    public class AufgabenContext : DbContext
    {
        public AufgabenContext (DbContextOptions<AufgabenContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetCoreKurs_Berlin.Data.Aufgaben> Aufgaben { get; set; }
    }
}
