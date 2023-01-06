﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Speaking.Models.Entities;

#nullable disable

namespace Speaking.Migrations
{
    [DbContext(typeof(SpeakingDBContext))]
    partial class SpeakingDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Speaking.Models.Entities.Scor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("AccuracyRate")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FalseWord")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("TextId")
                        .HasColumnType("int");

                    b.Property<int>("TrueWord")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TextId");

                    b.HasIndex("UserId");

                    b.ToTable("Scor", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccuracyRate = 50.0,
                            CreatedDate = new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5699),
                            FalseWord = 20,
                            IsDelete = false,
                            TextId = 1,
                            TrueWord = 20,
                            UpdatedDate = new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5700),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            AccuracyRate = 60.0,
                            CreatedDate = new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5703),
                            FalseWord = 20,
                            IsDelete = false,
                            TextId = 2,
                            TrueWord = 30,
                            UpdatedDate = new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5704),
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            AccuracyRate = 20.0,
                            CreatedDate = new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5705),
                            FalseWord = 40,
                            IsDelete = false,
                            TextId = 3,
                            TrueWord = 10,
                            UpdatedDate = new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5706),
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            AccuracyRate = 100.0,
                            CreatedDate = new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5706),
                            FalseWord = 0,
                            IsDelete = false,
                            TextId = 4,
                            TrueWord = 20,
                            UpdatedDate = new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5707),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Speaking.Models.Entities.Text", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("TextContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Text", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5678),
                            IsDelete = false,
                            TextContent = "I live in a house near the mountains. I have two brothers and one sister, and I was born last. My father teaches mathematics, and my mother is a nurse at a big hospital. My brothers are very smart and work hard in school. My sister is a nervous girl, but she is very kind. My grandmother also lives with us. She came from Italy when I was two years old. She has grown old, but she is still very strong. She cooks the best food!\r\n\r\nMy family is very important to me. We do lots of things together. My brothers and I like to go on long walks in the mountains. My sister likes to cook with my grandmother. On the weekends we all play board games together. We laugh and always have a good time. I love my family very much.",
                            Title = "My Wonderful Family",
                            UpdatedDate = new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5679)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5681),
                            IsDelete = false,
                            TextContent = "First, I wake up. Then, I get dressed. I walk to school. I do not ride a bike. I do not ride the bus. I like to go to school. It rains. I do not like rain. I eat lunch. I eat a sandwich and an apple.\r\n\r\nI play outside. I like to play. I read a book. I like to read books. I walk home. I do not like walking home. My mother cooks soup for dinner. The soup is hot. Then, I go to bed. I do not like to go to bed.",
                            Title = "My day",
                            UpdatedDate = new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5682)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5683),
                            IsDelete = false,
                            TextContent = "",
                            Title = "Hi! Nice to meet you! My name is John Smith. I am 19 and a student in college. I go to college in New York. My favorite courses are Geometry, French, and History. English is my hardest course. My professors are very friendly and smart. It’s my second year in college now. I love it!\r\n\r\nI live in a big house on Ivy Street. It’s near the college campus. I share the house with three other students. Their names are Bill, Tony, and Paul. We help each other with homework. On the weekend, we play football together.\r\n\r\nI have a younger brother. He just started high school. He is 14 and lives with my parents. They live on Mulberry Street in Boston. Sometimes they visit me in New York. I am happy when they visit. My Mom always brings me sweets and candy when they come. I really miss them, too!",
                            UpdatedDate = new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5683)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5684),
                            IsDelete = false,
                            TextContent = "Every year we go to Florida. We like to go to the beach.\r\n\r\nMy favorite beach is called Emerson Beach. It is very long, with soft sand and palm trees. It is very beautiful. I like to make sandcastles and watch the sailboats go by. Sometimes there are dolphins and whales in the water!\r\n\r\nEvery morning we look for shells in the sand. I found fifteen big shells last year. I put them in a special place in my room. This year I want to learn to surf. It is hard to surf, but so much fun! My sister is a good surfer. She says that she can teach me. I hope I can do it!",
                            Title = "Our Vacation",
                            UpdatedDate = new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5685)
                        });
                });

            modelBuilder.Entity("Speaking.Models.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5265),
                            Email = "muhammetcagatay@gmail.com",
                            FirstName = "Muhammet",
                            IsDelete = false,
                            LastName = "Çağatay",
                            UpdatedDate = new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5275)
                        });
                });

            modelBuilder.Entity("Speaking.Models.Entities.Scor", b =>
                {
                    b.HasOne("Speaking.Models.Entities.Text", "Text")
                        .WithMany("Scors")
                        .HasForeignKey("TextId")
                        .IsRequired()
                        .HasConstraintName("FK_Scor_Text");

                    b.HasOne("Speaking.Models.Entities.User", "User")
                        .WithMany("Scors")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Scor_User");

                    b.Navigation("Text");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Speaking.Models.Entities.Text", b =>
                {
                    b.Navigation("Scors");
                });

            modelBuilder.Entity("Speaking.Models.Entities.User", b =>
                {
                    b.Navigation("Scors");
                });
#pragma warning restore 612, 618
        }
    }
}