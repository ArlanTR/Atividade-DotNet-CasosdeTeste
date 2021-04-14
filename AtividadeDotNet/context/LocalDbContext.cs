using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AtividadeDotNet.Entities;

namespace AtividadeDotNet.context
{
    public class LocalDbContext : DbContext
    {
        public LocalDbContext(DbContextOptions<LocalDbContext> opt) : base(opt)
        {

        }
        public DbSet<Sapato> sapato { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        { 
        
        }
    }
}
