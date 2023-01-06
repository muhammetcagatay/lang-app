using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace User.Service.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "City", "Country", "CreatedDate", "Email", "FirstName", "IsDelete", "LastName", "MiddleName", "Password", "UpdatedDate" },
                values: new object[] { 1, 30, "Rize", "Turkey", new DateTime(2023, 1, 5, 23, 3, 1, 768, DateTimeKind.Local).AddTicks(6711), "muhammetcagatay@gmail.com", "Muhammet", false, "Çağatay", null, "AINArj8EtJkT2z621sKRZWcu57ldVnf++g4kwpg/OQdjJvLdYhPF8B/kkIBHUIygKA==", new DateTime(2023, 1, 5, 23, 3, 1, 768, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.CreateIndex(
                name: "Unique_Person",
                table: "Person",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
