using E_commerce_Mvc_app.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;


namespace E_commerce_Mvc_app.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
     /*DataBase Connection*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-GGJC2K1;Initial Catalog=test;Integrated Security=True;");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey
                (m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey
                (m => m.ActorId);
            base.OnModelCreating(modelBuilder);

        }

        public  DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public  DbSet<Actor_Movie> Actors_Movies { get; set; }
        public  DbSet<Cinema> Cinemas { get; set; }
        public  DbSet<Producer> Producers { get; set; }

    }


}

