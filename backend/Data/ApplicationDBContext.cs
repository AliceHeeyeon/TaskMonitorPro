using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // modelBuilder.Entity<Job>().ToTable("Jobs");
            // modelBuilder.Entity<User>().ToTable("Users");

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserName)
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PasswordHash)
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Job>()
                .Property(j => j.GrossProfit)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Job>()
                .Property(j => j.JobTitle)
                .HasColumnType("varchar(255)");

            modelBuilder.Entity<Job>()
                .Property(j => j.JobDescription)
                .HasColumnType("varchar(255)");

            modelBuilder.Entity<Job>()
                .Property(j => j.JobStatus)
                .HasColumnType("varchar(50)");

            modelBuilder.Entity<Job>()
                .Property(j => j.Priority)
                .HasColumnType("varchar(50)");

            modelBuilder.Entity<Job>()
                .Property(j => j.Comments)
                .HasColumnType("varchar(255)");
        }
    }
}