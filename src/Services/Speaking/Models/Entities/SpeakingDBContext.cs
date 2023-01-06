using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Speaking.Models.Entities
{
    public partial class SpeakingDBContext : DbContext
    {
        public SpeakingDBContext()
        {
        }

        public SpeakingDBContext(DbContextOptions<SpeakingDBContext> options)
            : base(options)
        {
            if (Database.GetAppliedMigrations().ToList().Count == 0)
            {
                Database.Migrate();
            }
        }

        public virtual DbSet<Scor> Scors { get; set; }
        public virtual DbSet<Text> Texts { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost,1433;Database=SpeakingDB;User Id=sa;Password=password123*;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Scor>(entity =>
            {
                entity.ToTable("Scor");

                entity.HasOne(d => d.Text)
                    .WithMany(p => p.Scors)
                    .HasForeignKey(d => d.TextId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Scor_Text");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Scors)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Scor_User");
            });

            modelBuilder.Entity<Text>(entity =>
            {
                entity.ToTable("Text");

                entity.Property(e => e.TextContent).IsRequired();

                entity.Property(e => e.Title).IsRequired();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();
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
            builder.Entity<Text>().HasData(
                new Text
                {
                    Id= 1,
                    IsDelete= false,
                    CreatedDate= DateTime.Now,
                    UpdatedDate= DateTime.Now,
                    Title = "My Wonderful Family",
                    TextContent = "I live in a house near the mountains. I have two brothers and one sister, and I was born last. My father teaches mathematics, and my mother is a nurse at a big hospital. My brothers are very smart and work hard in school. My sister is a nervous girl, but she is very kind. My grandmother also lives with us. She came from Italy when I was two years old. She has grown old, but she is still very strong. She cooks the best food!\r\n\r\nMy family is very important to me. We do lots of things together. My brothers and I like to go on long walks in the mountains. My sister likes to cook with my grandmother. On the weekends we all play board games together. We laugh and always have a good time. I love my family very much."
                },
                new Text
                {
                    Id = 2,
                    IsDelete = false,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Title = "My day",
                    TextContent = "First, I wake up. Then, I get dressed. I walk to school. I do not ride a bike. I do not ride the bus. I like to go to school. It rains. I do not like rain. I eat lunch. I eat a sandwich and an apple.\r\n\r\nI play outside. I like to play. I read a book. I like to read books. I walk home. I do not like walking home. My mother cooks soup for dinner. The soup is hot. Then, I go to bed. I do not like to go to bed."
                },
                new Text
                {
                    Id = 3,
                    IsDelete = false,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Title = "Hi! Nice to meet you! My name is John Smith. I am 19 and a student in college. I go to college in New York. My favorite courses are Geometry, French, and History. English is my hardest course. My professors are very friendly and smart. It’s my second year in college now. I love it!\r\n\r\nI live in a big house on Ivy Street. It’s near the college campus. I share the house with three other students. Their names are Bill, Tony, and Paul. We help each other with homework. On the weekend, we play football together.\r\n\r\nI have a younger brother. He just started high school. He is 14 and lives with my parents. They live on Mulberry Street in Boston. Sometimes they visit me in New York. I am happy when they visit. My Mom always brings me sweets and candy when they come. I really miss them, too!",
                    TextContent = ""
                },
                new Text
                {
                    Id = 4,
                    IsDelete = false,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Title = "Our Vacation",
                    TextContent = "Every year we go to Florida. We like to go to the beach.\r\n\r\nMy favorite beach is called Emerson Beach. It is very long, with soft sand and palm trees. It is very beautiful. I like to make sandcastles and watch the sailboats go by. Sometimes there are dolphins and whales in the water!\r\n\r\nEvery morning we look for shells in the sand. I found fifteen big shells last year. I put them in a special place in my room. This year I want to learn to surf. It is hard to surf, but so much fun! My sister is a good surfer. She says that she can teach me. I hope I can do it!"
                }
            );
            builder.Entity<Scor>().HasData(
                new Scor
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    TextId = 1,
                    UserId = 1,
                    TrueWord = 20,
                    FalseWord = 20,
                    AccuracyRate = 50,
                },
                new Scor
                {
                    Id = 2,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    TextId = 2,
                    UserId = 1,
                    TrueWord = 30,
                    FalseWord = 20,
                    AccuracyRate = 60,
                },
                new Scor
                {
                    Id = 3,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    TextId = 3,
                    UserId = 1,
                    TrueWord = 10,
                    FalseWord = 40,
                    AccuracyRate = 20,
                },
                new Scor
                {
                    Id = 4,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    TextId = 4,
                    UserId = 1,
                    TrueWord = 20,
                    FalseWord = 0,
                    AccuracyRate = 100,
                }
            );
        }
    }
}
