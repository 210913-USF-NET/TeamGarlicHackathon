using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DL
{
    public class HackDBContext : DbContext
    {
        public HackDBContext() : base() { }
        public HackDBContext(DbContextOptions options) : base(options) { }
        public DbSet<ModelVideo> Vids { get; set; }

        
    }
}
