using ANIMALS.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ANIMALS.Data
{
    public class AnimalsDbContext : DbContext
    {
        public AnimalsDbContext(DbContextOptions<AnimalsDbContext> options) : base(options)
        {
        }
        public DbSet<Animal> Animals { get; set; }
    }
}
