using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMVCSample.Models;

namespace WebMVCSample.Data
{
    public class KursDbContext : DbContext
    {
        public KursDbContext (DbContextOptions<KursDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebMVCSample.Models.Kurs> Kurs { get; set; }
    }
}
