using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Scor.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotificationHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    SentEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotificationHistory_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ScorHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrueAnswer = table.Column<int>(type: "int", nullable: false),
                    FalseAnswer = table.Column<int>(type: "int", nullable: false),
                    TotalTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Scor = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScorHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScorHistory_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedDate", "Email", "FirstName", "IsDelete", "LastName", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4602), "muhammetcagatay@gmail.com", "Muhammet", false, "Çağatay", new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.InsertData(
                table: "NotificationHistory",
                columns: new[] { "Id", "CreatedDate", "EmailContent", "IsDelete", "SentDate", "SentEmailAddress", "UpdatedDate", "UserId" },
                values: new object[] { 1, new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4760), "Başarılarınız", false, new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4761), "muhammetcagatay@gmail.com", new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4760), 1 });

            migrationBuilder.InsertData(
                table: "ScorHistory",
                columns: new[] { "Id", "CreatedDate", "FalseAnswer", "IsDelete", "Scor", "TotalTime", "TrueAnswer", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4734), 20, false, 50, new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4738), 20, new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4736), 1 },
                    { 2, new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4741), 20, false, 60, new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4743), 30, new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4741), 1 },
                    { 3, new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4743), 40, false, 20, new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4745), 10, new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4744), 1 },
                    { 4, new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4745), 0, false, 100, new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4746), 20, new DateTime(2023, 1, 5, 23, 44, 15, 215, DateTimeKind.Local).AddTicks(4746), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotificationHistory_UserId",
                table: "NotificationHistory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ScorHistory_UserId",
                table: "ScorHistory",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotificationHistory");

            migrationBuilder.DropTable(
                name: "ScorHistory");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
