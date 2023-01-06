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
                values: new object[] { 1, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(523), false, "Muhammet", "Çağatay", new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(523) });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDelete", "Title", "UpdatedDate", "UserId" },
                values: new object[] { 1, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(782), "Temel Seviyede İngilizce Öğrenme Kursu", false, "Temel İngilizce", new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(782), 1 });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CourseId", "CreatedDate", "IsDelete", "Title", "UpdatedDate" },
                values: new object[] { 1, 1, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(705), false, "A1", new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(706) });

            migrationBuilder.InsertData(
                table: "CardSession",
                columns: new[] { "Id", "CardId", "CreatedDate", "EndDate", "FalseCount", "IsDelete", "IsFinish", "Scor", "StartDate", "TrueCount", "UpdatedDate", "UserId" },
                values: new object[] { 1, 1, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(717), new DateTime(2023, 1, 5, 23, 30, 54, 812, DateTimeKind.Local).AddTicks(718), 2, false, true, null, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(721), 2, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(717), 1 });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "CardId", "Context", "CreatedDate", "IsDelete", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, "Door", new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(646), false, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(647) },
                    { 2, 1, "Window", new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(649), false, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(649) },
                    { 3, 1, "Computer", new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(651), false, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(652) }
                });

            migrationBuilder.InsertData(
                table: "WordAnswer",
                columns: new[] { "Id", "Answer", "CreatedDate", "IsDelete", "IsTrue", "UpdatedDate", "WordId" },
                values: new object[,]
                {
                    { 1, "Kapı", new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(666), false, true, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(667), 1 },
                    { 2, "Kaldırım", new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(669), false, false, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(669), 1 },
                    { 3, "Uzay", new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(671), false, false, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(671), 1 },
                    { 4, "Şirket", new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(673), false, false, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(673), 1 },
                    { 5, "Pencere", new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(675), false, true, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(675), 2 },
                    { 6, "Limonata", new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(676), false, false, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(677), 2 },
                    { 7, "Sandalye", new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(678), false, false, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(679), 2 },
                    { 8, "Teknokent", new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(680), false, false, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(681), 2 },
                    { 9, "Bilgisayar", new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(682), false, true, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(683), 3 },
                    { 10, "Bardak", new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(684), false, false, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(685), 3 },
                    { 11, "Çanta", new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(686), false, false, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(687), 3 },
                    { 12, "Kalemlik", new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(688), false, false, new DateTime(2023, 1, 5, 23, 29, 54, 812, DateTimeKind.Local).AddTicks(689), 3 }
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
