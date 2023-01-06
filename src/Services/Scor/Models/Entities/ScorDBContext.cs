using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace Scor.Models.Entities
{
    public partial class ScorDBContext : DbContext
    {
        public ScorDBContext()
        {
        }

        public ScorDBContext(DbContextOptions<ScorDBContext> options)
            : base(options)
        {
            if (Database.GetAppliedMigrations().ToList().Count == 0)
            {
                Database.Migrate();
            }
        }

        public virtual DbSet<NotificationHistory> NotificationHistories { get; set; } = null!;
        public virtual DbSet<ScorHistory> ScorHistories { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ScorDB;User Id=sa;Password=password123*;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NotificationHistory>(entity =>
            {
                entity.ToTable("NotificationHistory");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.NotificationHistories)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationHistory_User");
            });

            modelBuilder.Entity<ScorHistory>(entity =>
            {
                entity.ToTable("ScorHistory");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ScorHistories)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScorHistory_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Email).HasMaxLength(50);
            });
            SeedData(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


        public static void SeedData(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Email = "muhammetcagatay@gmail.com",
                    FirstName = "Muhammet",
                    LastName = "Çağatay",
                }
            );

            builder.Entity<ScorHistory>().HasData(
                new ScorHistory
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    UserId = 1,
                    TrueAnswer = 20,
                    FalseAnswer = 20,
                    Scor = 50,
                    TotalTime= DateTime.Now,
                },
                new ScorHistory
                {
                    Id = 2,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    UserId = 1,
                    TrueAnswer = 30,
                    FalseAnswer = 20,
                    Scor = 60,
                    TotalTime = DateTime.Now,
                },
                new ScorHistory
                {
                    Id = 3,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    UserId = 1,
                    TrueAnswer = 10,
                    FalseAnswer = 40,
                    Scor = 20,
                    TotalTime = DateTime.Now,
                },
                new ScorHistory
                {
                    Id = 4,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    UserId = 1,
                    TrueAnswer = 20,
                    FalseAnswer = 0,
                    Scor = 100,
                    TotalTime = DateTime.Now,
                }
            );

            builder.Entity<NotificationHistory>().HasData(
                new NotificationHistory
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    SentDate= DateTime.Now,
                    EmailContent = "Başarılarınız",
                    SentEmailAddress = "muhammetcagatay@gmail.com",
                    UserId = 1,
                }
            );
        }
    }
}
