using E_commerce_Mvc_app.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;


namespace E_commerce_Mvc_app.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
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

        public virtual DbSet<Actor> Actors{get; set;}
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Actor_Movie> Actors_Movies { get; set; }
        public virtual DbSet<Cinema> Cinemas { get; set; }

        public virtual DbSet<Producer> Producers { get; set; }

    }


    }

