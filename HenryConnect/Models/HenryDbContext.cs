using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace HenryConnect.Models
{
    public class HenryDbContext : DbContext
    {
        public HenryDbContext(DbContextOptions<HenryDbContext> options) 
            : base(options) {  }
        public DbSet<ABook> Book { get; set; }
    }
}
