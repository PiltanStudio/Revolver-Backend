using RevolverBackend.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RevolverBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }  // Create a table for Player
        public DbSet<User> Users { get; set; }

    }
}
