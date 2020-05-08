using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;


namespace crudDotnet.Models
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> options) : base(options)
        {
        }

        public DbSet<Filme> Filmes { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Filme>().HasKey(f => f.FilmeId);
            base.OnModelCreating(builder);
        }
    }
}
