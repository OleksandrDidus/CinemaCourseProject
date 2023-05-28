using Cinema.Data.Models;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity.Infrastructure;

namespace Cinema.Data
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        //public DbSet<CustomModel> CustomModel { get; set; }

        public DbSet<Genre> Genre { get; set; }

        public DbSet<Film> Film { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<Place> Places { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

    }
}
