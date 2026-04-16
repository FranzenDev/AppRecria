using AppRecria.API.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace AppRecria.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Animal> Animais { get; set; }
        public DbSet<Pesagem> Pesagens { get; set; }
    }
}