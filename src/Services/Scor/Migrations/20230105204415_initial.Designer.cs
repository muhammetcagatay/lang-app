// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Scor.Models.Entities;

#nullable disable

namespace Scor.Migrations
{
    [DbContext(typeof(ScorDBContext))]
    [Migration("20230105204415_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Scor.Models.Entities.NotificationHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("SentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SentEmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("NotificationHistory", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4760),
                            EmailContent = "Başarılarınız",
                            IsDelete = false,
                            SentDate = new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4761),
                            SentEmailAddress = "muhammetcagatay@gmail.com",
                            UpdatedDate = new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4760),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Scor.Models.Entities.ScorHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FalseAnswer")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("Scor")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TotalTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TrueAnswer")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ScorHistory", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4734),
                            FalseAnswer = 20,
                            IsDelete = false,
                            Scor = 50,
                            TotalTime = new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4738),
                            TrueAnswer = 20,
                            UpdatedDate = new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4736),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4741),
                            FalseAnswer = 20,
                            IsDelete = false,
                            Scor = 60,
                            TotalTime = new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4743),
                            TrueAnswer = 30,
                            UpdatedDate = new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4741),
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4743),
                            FalseAnswer = 40,
                            IsDelete = false,
                            Scor = 20,
                            TotalTime = new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4745),
                            TrueAnswer = 10,
                            UpdatedDate = new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4744),
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4745),
                            FalseAnswer = 0,
                            IsDelete = false,
                            Scor = 100,
                            TotalTime = new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4746),
                            TrueAnswer = 20,
                            UpdatedDate = new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4746),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Scor.Models.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4602),
                            Email = "muhammetcagatay@gmail.com",
                            FirstName = "Muhammet",
                            IsDelete = false,
                            LastName = "Çağatay",
                            UpdatedDate = new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4613)
                        });
                });

            modelBuilder.Entity("Scor.Models.Entities.NotificationHistory", b =>
                {
                    b.HasOne("Scor.Models.Entities.User", "User")
                        .WithMany("NotificationHistories")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_NotificationHistory_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Scor.Models.Entities.ScorHistory", b =>
                {
                    b.HasOne("Scor.Models.Entities.User", "User")
                        .WithMany("ScorHistories")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_ScorHistory_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Scor.Models.Entities.User", b =>
                {
                    b.Navigation("NotificationHistories");

                    b.Navigation("ScorHistories");
                });
#pragma warning restore 612, 618
        }
    }
}
