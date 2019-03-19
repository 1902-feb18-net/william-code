using Microsoft.EntityFrameworkCore;
using MoviesSite.BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesSite.DataAccess
{
    public class MovieDbContext : DbContext

    {
        public MovieDbContext() { }

        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Genre> Genre { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(builder =>
            {
                builder.HasKey(m => m.Id);
                builder.Property(m => m.Id).UseSqlServerIdentityColumn();
                builder.Property(m => m.Title)
                                .IsRequired()
                                .HasMaxLength(128);
                builder.Property(m => m.DateReleased)
                                .HasColumnType("DATEtIME2");
                builder.HasOne(m => m.Genre)
                        .WithMany(g => g.Movies);
            });

            modelBuilder.Entity<Genre>(builder =>
            {
                //defaults probably fine
            });
        }
    }
}
