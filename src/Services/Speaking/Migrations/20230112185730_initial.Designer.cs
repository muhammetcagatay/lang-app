﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Speaking.Models.Entities;

#nullable disable

namespace Speaking.Migrations
{
    [DbContext(typeof(SpeakingDBContext))]
    [Migration("20230112185730_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            CreatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6835),
                            FalseWord = 20,
                            IsDelete = false,
                            TextId = 1,
                            TrueWord = 20,
                            UpdatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6835),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            AccuracyRate = 60.0,
                            CreatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6838),
                            FalseWord = 20,
                            IsDelete = false,
                            TextId = 2,
                            TrueWord = 30,
                            UpdatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6838),
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            AccuracyRate = 20.0,
                            CreatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6840),
                            FalseWord = 40,
                            IsDelete = false,
                            TextId = 3,
                            TrueWord = 10,
                            UpdatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6840),
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            AccuracyRate = 100.0,
                            CreatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6841),
                            FalseWord = 0,
                            IsDelete = false,
                            TextId = 4,
                            TrueWord = 20,
                            UpdatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6842),
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
                            CreatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6813),
                            IsDelete = false,
                            TextContent = "I live in a house near the mountains. I have two brothers and one sister, and I was born last. My father teaches mathematics, and my mother is a nurse at a big hospital. My brothers are very smart and work hard in school. My sister is a nervous girl, but she is very kind. My grandmother also lives with us. She came from Italy when I was two years old. She has grown old, but she is still very strong. She cooks the best food!\r\n\r\nMy family is very important to me. We do lots of things together. My brothers and I like to go on long walks in the mountains. My sister likes to cook with my grandmother. On the weekends we all play board games together. We laugh and always have a good time. I love my family very much.",
                            Title = "My Wonderful Family",
                            UpdatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6813)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6815),
                            IsDelete = false,
                            TextContent = "First, I wake up. Then, I get dressed. I walk to school. I do not ride a bike. I do not ride the bus. I like to go to school. It rains. I do not like rain. I eat lunch. I eat a sandwich and an apple.\r\n\r\nI play outside. I like to play. I read a book. I like to read books. I walk home. I do not like walking home. My mother cooks soup for dinner. The soup is hot. Then, I go to bed. I do not like to go to bed.",
                            Title = "My day",
                            UpdatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6815)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6817),
                            IsDelete = false,
                            TextContent = "Hi! Nice to meet you! My name is John Smith. I am 19 and a student in college. I go to college in New York. My favorite courses are Geometry, French, and History. English is my hardest course. My professors are very friendly and smart. It’s my second year in college now. I love it!",
                            Title = "My name is John",
                            UpdatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6817)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6818),
                            IsDelete = false,
                            TextContent = "Every year we go to Florida. We like to go to the beach.\r\n\r\nMy favorite beach is called Emerson Beach. It is very long, with soft sand and palm trees. It is very beautiful. I like to make sandcastles and watch the sailboats go by. Sometimes there are dolphins and whales in the water!\r\n\r\nEvery morning we look for shells in the sand. I found fifteen big shells last year. I put them in a special place in my room. This year I want to learn to surf. It is hard to surf, but so much fun! My sister is a good surfer. She says that she can teach me. I hope I can do it!",
                            Title = "Our Vacation",
                            UpdatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6818)
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6819),
                            IsDelete = false,
                            TextContent = "Mr. and Mrs. Smith have one son and one daughter. The son's name is John. The daughter's name is Sarah. he Smiths live in a house.They have a living room.They watch TV in the living room.The father cooks food in the kitchen.They eat in the dining room.The house has two bedrooms.They sleep in the bedrooms.They keep their clothes in the closet.There is one bathroom. They brush their teeth in the bathroom.",
                            Title = "The House",
                            UpdatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6819)
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6820),
                            IsDelete = false,
                            TextContent = "Jack was hungry. He walked to the kitchen. He got out some eggs. He took out some oil. He placed a skillet on the stove. Next, he turned on the heat. He poured the oil into the skillet. He cracked the eggs into a bowl. He stirred the eggs. Then, he poured them into the hot skillet. He waited while the eggs cooked. They cooked for two minutes. He heard them cooking. They popped in the oil.",
                            Title = "Preparing food",
                            UpdatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6821)
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
                            CreatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6701),
                            Email = "muhammetcagatay@gmail.com",
                            FirstName = "Muhammet",
                            IsDelete = false,
                            LastName = "Çağatay",
                            UpdatedDate = new DateTime(2023, 1, 12, 21, 57, 29, 913, DateTimeKind.Local).AddTicks(6709)
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