using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vocabulary.API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Users",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Courses",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CourseUsers",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseUsers", x => new { x.CourseId, x.UserId });
                    table.ForeignKey(
                        name: "FK_CourseUsers_Courses",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CourseUsers_Users",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CardSession",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsFinish = table.Column<bool>(type: "bit", nullable: false),
                    TrueCount = table.Column<int>(type: "int", nullable: false),
                    FalseCount = table.Column<int>(type: "int", nullable: false),
                    Scor = table.Column<double>(type: "float", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardSession", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardSession_Cards",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CardSession_Users",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Context = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Words_Cards",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WordAnswer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsTrue = table.Column<bool>(type: "bit", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WordId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordAnswer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WordAnswer_Words",
                        column: x => x.WordId,
                        principalTable: "Words",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "IsDelete", "Name", "Surname", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4778), false, "Muhammet", "Çağatay", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDelete", "Title", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5026), "İngilizce'nin ilham verici öğretim metodu ve kapsamlı kurs Bölüm 1 karşınızda. Kendini İngilizce tanıt, İngiltere'yi tanı, ve insanları gülümsetmek için onlarca İngilizce günlük ifadeyi öğren. Günlük konuşma İngilizcesini öğrenmek artık çok kolay.", false, "İngilizce 1", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5026), 1 },
                    { 2, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5028), "Kendini İngilizce tanıt, Amerika'yı tanı, ve insanları gülümsetmek için onlarca İngilizce günlük ifadeyi öğren. Amerikan İngilizcesini öğrenmek artık çok kolay.", false, "Amerikan İngilizcesi 1", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5029), 1 },
                    { 3, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5031), "Kendini Almanca tanıt, Almanya'yı tanı, ve insanları gülümsetmek için onlarca Almanca günlük ifadeyi öğren. Günlük konuşma Almancasını öğrenmek artık çok kolay.", false, "Almanca 1", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5031), 1 },
                    { 4, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5033), "", false, "En Çok Kullanılan 3000 Kelime", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5033), 1 },
                    { 5, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5035), " Bu kurs temel kelimeler ve ifadeler ile hemen İngilizce konuşabilmeye başlayabilmeniz için tasarlanmıştır.", false, "İngilizce'yi Söküyoruz!", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5036), 1 },
                    { 6, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5037), "İngilizce'de yaygın olarak kullanılan 250 pratik. Sık kullanılan Sorular, Durumlar v.b", false, "250 İngilizce Pratik", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5038), 1 },
                    { 7, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5040), "Phrasal Verbs Türkçe Anlamları", false, "Phrasal Verbs Türkçe", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5040), 1 },
                    { 8, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5042), "", false, "YDS Çıkmış Kelimeler", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5042), 1 },
                    { 9, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5044), "Oxford eğitmenleri tarafından hazırlanan, İngilizce'de en çok kullanılan 3000 kelime", false, "The Oxford 3000 (İngilizce - Türkçe)", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5044), 1 },
                    { 10, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5047), "Amerikan Kültür ve Dil Kursu içi Hazırlanmış Portfolyosundaki Kelimeleri İçeren Mükemmel Bir Kurs", false, "İngilizcedeki En Önemli 1250 Kelime", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5048), 1 },
                    { 11, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5050), "Advanced English for speakers of Turkish: this course consists of a collection of useful and idiomatic phrases or sentences to help you improve your pronunciation as well as develop fluency when using complex structures.", false, "Gelişmiş ingilizce - Advanced English", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5050), 1 },
                    { 12, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5052), "Temel Seviyede İngilizce Öğrenme Kursu", false, "Temel İngilizce", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5052), 1 },
                    { 13, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5054), "", false, "İngilizce İlk 1000 Kelime", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5054), 1 },
                    { 14, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5056), "A1, A2 seviyeleri için temel kelimeler", false, "İngilizce Temel Kelimeler", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5056), 1 },
                    { 15, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5058), "ÖSYM Yabancı Dil Sınavı (YDS) için seçilmiş kelimeler.", false, "YDS İngilizce Kelimeleri", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5058), 1 },
                    { 16, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5060), "Günde 30 Kelime ile 1 Ayda 900 Kelime !", false, "30 Days English Challange", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5061), 1 }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CourseId", "CreatedDate", "IsDelete", "Title", "UpdatedDate" },
                values: new object[] { 1, 1, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4945), false, "A1", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.InsertData(
                table: "CardSession",
                columns: new[] { "Id", "CardId", "CreatedDate", "EndDate", "FalseCount", "IsDelete", "IsFinish", "Scor", "StartDate", "TrueCount", "UpdatedDate", "UserId" },
                values: new object[] { 1, 1, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5001), new DateTime(2023, 1, 12, 21, 58, 45, 855, DateTimeKind.Local).AddTicks(5002), 2, false, true, null, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5009), 2, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(5001), 1 });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "CardId", "Context", "CreatedDate", "IsDelete", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, "Door", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4885), false, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4885) },
                    { 2, 1, "Window", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4889), false, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4890) },
                    { 3, 1, "Computer", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4892), false, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4892) }
                });

            migrationBuilder.InsertData(
                table: "WordAnswer",
                columns: new[] { "Id", "Answer", "CreatedDate", "IsDelete", "IsTrue", "UpdatedDate", "WordId" },
                values: new object[,]
                {
                    { 1, "Kapı", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4905), false, true, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4905), 1 },
                    { 2, "Kaldırım", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4908), false, false, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4908), 1 },
                    { 3, "Uzay", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4910), false, false, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4910), 1 },
                    { 4, "Şirket", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4912), false, false, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4913), 1 },
                    { 5, "Pencere", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4914), false, true, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4915), 2 },
                    { 6, "Limonata", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4917), false, false, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4917), 2 },
                    { 7, "Sandalye", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4918), false, false, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4919), 2 },
                    { 8, "Teknokent", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4920), false, false, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4921), 2 },
                    { 9, "Bilgisayar", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4923), false, true, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4923), 3 },
                    { 10, "Bardak", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4924), false, false, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4925), 3 },
                    { 11, "Çanta", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4926), false, false, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4927), 3 },
                    { 12, "Kalemlik", new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4928), false, false, new DateTime(2023, 1, 12, 21, 57, 45, 855, DateTimeKind.Local).AddTicks(4929), 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CourseId",
                table: "Cards",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CardSession_CardId",
                table: "CardSession",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardSession_UserId",
                table: "CardSession",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_UserId",
                table: "Courses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseUsers_UserId",
                table: "CourseUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WordAnswer_WordId",
                table: "WordAnswer",
                column: "WordId");

            migrationBuilder.CreateIndex(
                name: "IX_Words_CardId",
                table: "Words",
                column: "CardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardSession");

            migrationBuilder.DropTable(
                name: "CourseUsers");

            migrationBuilder.DropTable(
                name: "WordAnswer");

            migrationBuilder.DropTable(
                name: "Words");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
