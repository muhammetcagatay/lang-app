using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace Vocabulary.API.Models.Entities
{
    public partial class VocabularyDBContext : DbContext
    {
        public VocabularyDBContext()
        {
        }

        public VocabularyDBContext(DbContextOptions<VocabularyDBContext> options)
            : base(options)
        {
            if (Database.GetAppliedMigrations().ToList().Count == 0)
            {
                Database.Migrate();
            }
        }

        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<CardSession> CardSessions { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Word> Words { get; set; }
        public virtual DbSet<WordAnswer> WordAnswers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost,1433;Database=VocabularyDB;User Id=sa;Password=password123*;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>(entity =>
            {
                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Cards)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cards_Courses");
            });

            modelBuilder.Entity<CardSession>(entity =>
            {
                entity.ToTable("CardSession");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.CardSessions)
                    .HasForeignKey(d => d.CardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CardSession_Cards");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CardSessions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CardSession_Users");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Courses_Users");

                entity.HasMany(d => d.Users)
                    .WithMany(p => p.CoursesNavigation)
                    .UsingEntity<Dictionary<string, object>>(
                        "CourseUser",
                        l => l.HasOne<User>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CourseUsers_Users"),
                        r => r.HasOne<Course>().WithMany().HasForeignKey("CourseId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CourseUsers_Courses"),
                        j =>
                        {
                            j.HasKey("CourseId", "UserId");

                            j.ToTable("CourseUsers");
                        });
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Surname).IsRequired();
            });

            modelBuilder.Entity<Word>(entity =>
            {
                entity.Property(e => e.Context).IsRequired();

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.Words)
                    .HasForeignKey(d => d.CardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Words_Cards");
            });

            modelBuilder.Entity<WordAnswer>(entity =>
            {
                entity.ToTable("WordAnswer");

                entity.Property(e => e.Answer).IsRequired();

                entity.HasOne(d => d.Word)
                    .WithMany(p => p.WordAnswers)
                    .HasForeignKey(d => d.WordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WordAnswer_Words");
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
                    Name = "Muhammet",
                    Surname = "Çağatay",
                }
            );
            builder.Entity<Word>().HasData(
                new Word
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Context = "Door",
                    CardId = 1,
                },
                new Word
                {
                    Id = 2,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Context = "Window",
                    CardId = 1,
                },
                new Word
                {
                    Id = 3,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Context = "Computer",
                    CardId = 1,
                }
            );
            builder.Entity<WordAnswer>().HasData(
                new WordAnswer
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Answer = "Kapı",
                    WordId = 1,
                    IsTrue = true
                },
                new WordAnswer
                {
                    Id = 2,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Answer = "Kaldırım",
                    WordId = 1,
                    IsTrue = false
                },
                new WordAnswer
                {
                    Id = 3,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Answer = "Uzay",
                    WordId = 1,
                    IsTrue = false
                },
                new WordAnswer
                {
                    Id = 4,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Answer = "Şirket",
                    WordId = 1,
                    IsTrue = false
                },
                new WordAnswer
                {
                    Id = 5,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Answer = "Pencere",
                    WordId = 2,
                    IsTrue = true
                },
                new WordAnswer
                {
                    Id = 6,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Answer = "Limonata",
                    WordId = 2,
                    IsTrue = false
                },
                new WordAnswer
                {
                    Id = 7,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Answer = "Sandalye",
                    WordId = 2,
                    IsTrue = false
                },
                new WordAnswer
                {
                    Id = 8,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Answer = "Teknokent",
                    WordId = 2,
                    IsTrue = false
                },
                new WordAnswer
                {
                    Id = 9,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Answer = "Bilgisayar",
                    WordId = 3,
                    IsTrue = true
                },
                new WordAnswer
                {
                    Id = 10,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Answer = "Bardak",
                    WordId = 3,
                    IsTrue = false
                },
                new WordAnswer
                {
                    Id = 11,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Answer = "Çanta",
                    WordId = 3,
                    IsTrue = false
                },
                new WordAnswer
                {
                    Id = 12,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Answer = "Kalemlik",
                    WordId = 3,
                    IsTrue = false
                }
            );
            builder.Entity<Card>().HasData(
                new Card
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Title = "A1",
                    CourseId = 1,
                }
            );
            builder.Entity<CardSession>().HasData(
                new CardSession
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    EndDate = DateTime.Now.AddMinutes(1),
                    StartDate = DateTime.Now,
                    FalseCount = 2,
                    TrueCount = 2,
                    IsFinish  =true,
                    CardId = 1,
                    UserId = 1,
                }
            );
            builder.Entity<Course>().HasData(
                new Course
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Title = "İngilizce 1",
                    Description = "İngilizce'nin ilham verici öğretim metodu ve kapsamlı kurs Bölüm 1 karşınızda. Kendini İngilizce tanıt, İngiltere'yi tanı, ve insanları gülümsetmek için onlarca İngilizce günlük ifadeyi öğren. Günlük konuşma İngilizcesini öğrenmek artık çok kolay.",
                    UserId = 1,
                },
                new Course
                {
                    Id = 2,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Title = "Amerikan İngilizcesi 1",
                    Description = "Kendini İngilizce tanıt, Amerika'yı tanı, ve insanları gülümsetmek için onlarca İngilizce günlük ifadeyi öğren. Amerikan İngilizcesini öğrenmek artık çok kolay.",
                    UserId = 1,
                },
                new Course
                {
                    Id = 3,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Title = "Almanca 1",
                    Description = "Kendini Almanca tanıt, Almanya'yı tanı, ve insanları gülümsetmek için onlarca Almanca günlük ifadeyi öğren. Günlük konuşma Almancasını öğrenmek artık çok kolay.",
                    UserId = 1,
                },
                new Course
                {
                    Id = 4,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Title = "En Çok Kullanılan 3000 Kelime",
                    Description = "",
                    UserId = 1,
                },
                new Course
                {
                    Id = 5,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Title = "İngilizce'yi Söküyoruz!",
                    Description = " Bu kurs temel kelimeler ve ifadeler ile hemen İngilizce konuşabilmeye başlayabilmeniz için tasarlanmıştır.",
                    UserId = 1,
                },
                new Course
                {
                    Id = 6,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Title = "250 İngilizce Pratik",
                    Description = "İngilizce'de yaygın olarak kullanılan 250 pratik. Sık kullanılan Sorular, Durumlar v.b",
                    UserId = 1,
                },
                new Course
                {
                    Id = 7,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Title = "Phrasal Verbs Türkçe",
                    Description = "Phrasal Verbs Türkçe Anlamları",
                    UserId = 1,
                },
                new Course
                {
                    Id = 8,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Title = "YDS Çıkmış Kelimeler",
                    Description = "",
                    UserId = 1,
                },
                new Course
                {
                    Id = 9,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Title = "The Oxford 3000 (İngilizce - Türkçe)",
                    Description = "Oxford eğitmenleri tarafından hazırlanan, İngilizce'de en çok kullanılan 3000 kelime",
                    UserId = 1,
                },
                new Course
                {
                    Id = 10,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Title = "İngilizcedeki En Önemli 1250 Kelime",
                    Description = "Amerikan Kültür ve Dil Kursu içi Hazırlanmış Portfolyosundaki Kelimeleri İçeren Mükemmel Bir Kurs",
                    UserId = 1,
                },
                new Course
                {
                    Id = 11,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Title = "Gelişmiş ingilizce - Advanced English",
                    Description = "Advanced English for speakers of Turkish: this course consists of a collection of useful and idiomatic phrases or sentences to help you improve your pronunciation as well as develop fluency when using complex structures.",
                    UserId = 1,
                },
                new Course
                {
                    Id = 12,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Title = "Temel İngilizce",
                    Description = "Temel Seviyede İngilizce Öğrenme Kursu",
                    UserId = 1,
                },
                new Course
                {
                    Id = 13,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Title = "İngilizce İlk 1000 Kelime",
                    Description = "",
                    UserId = 1,
                },
                new Course
                {
                    Id = 14,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Title = "İngilizce Temel Kelimeler",
                    Description = "A1, A2 seviyeleri için temel kelimeler",
                    UserId = 1,
                },
                new Course
                {
                    Id = 15,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Title = "YDS İngilizce Kelimeleri",
                    Description = "ÖSYM Yabancı Dil Sınavı (YDS) için seçilmiş kelimeler.",
                    UserId = 1,
                },
                new Course
                {
                    Id = 16,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Title = "30 Days English Challange",
                    Description = "Günde 30 Kelime ile 1 Ayda 900 Kelime !",
                    UserId = 1,
                }

            );
        }
    }
}
