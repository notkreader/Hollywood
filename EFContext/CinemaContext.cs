using Hollywood.Models.Addresses;
using Hollywood.Models.Cinemas;
using Hollywood.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace Hollywood.EFContext
{
    public class CinemaContext : DbContext
    {
        public DbSet<Address> Addresses {get; set;}
        public DbSet<Country> Countries {get; set;}
        public DbSet<Cinema> Cinemas {get; set;}
        public DbSet<Movie> Movies {get; set;}
        public DbSet<CinemaMovie> CinemaMovies {get; set;}
        public DbSet<AUser> Users {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer("Server=PTLPK1730000128;Database=CinemaDB;User Id=sa;Password=1234");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Address>().ToTable("Addresses");
            modelBuilder.Entity<Country>().ToTable("Countries");
            modelBuilder.Entity<Cinema>().ToTable("Cinemas");
            modelBuilder.Entity<Movie>().ToTable("Movies");
            modelBuilder.Entity<CinemaMovie>().ToTable("CinemaMovies"); 
            modelBuilder.Entity<AUser>().ToTable("Users");
        }
    }
}