using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Speaking.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Text",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    TextContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Text", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Scor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    TrueWord = table.Column<int>(type: "int", nullable: false),
                    FalseWord = table.Column<int>(type: "int", nullable: false),
                    AccuracyRate = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TextId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scor_Text",
                        column: x => x.TextId,
                        principalTable: "Text",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Scor_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Text",
                columns: new[] { "Id", "CreatedDate", "IsDelete", "TextContent", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5678), false, "I live in a house near the mountains. I have two brothers and one sister, and I was born last. My father teaches mathematics, and my mother is a nurse at a big hospital. My brothers are very smart and work hard in school. My sister is a nervous girl, but she is very kind. My grandmother also lives with us. She came from Italy when I was two years old. She has grown old, but she is still very strong. She cooks the best food!\r\n\r\nMy family is very important to me. We do lots of things together. My brothers and I like to go on long walks in the mountains. My sister likes to cook with my grandmother. On the weekends we all play board games together. We laugh and always have a good time. I love my family very much.", "My Wonderful Family", new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5679) },
                    { 2, new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5681), false, "First, I wake up. Then, I get dressed. I walk to school. I do not ride a bike. I do not ride the bus. I like to go to school. It rains. I do not like rain. I eat lunch. I eat a sandwich and an apple.\r\n\r\nI play outside. I like to play. I read a book. I like to read books. I walk home. I do not like walking home. My mother cooks soup for dinner. The soup is hot. Then, I go to bed. I do not like to go to bed.", "My day", new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5682) },
                    { 3, new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5683), false, "", "Hi! Nice to meet you! My name is John Smith. I am 19 and a student in college. I go to college in New York. My favorite courses are Geometry, French, and History. English is my hardest course. My professors are very friendly and smart. It’s my second year in college now. I love it!\r\n\r\nI live in a big house on Ivy Street. It’s near the college campus. I share the house with three other students. Their names are Bill, Tony, and Paul. We help each other with homework. On the weekend, we play football together.\r\n\r\nI have a younger brother. He just started high school. He is 14 and lives with my parents. They live on Mulberry Street in Boston. Sometimes they visit me in New York. I am happy when they visit. My Mom always brings me sweets and candy when they come. I really miss them, too!", new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5683) },
                    { 4, new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5684), false, "Every year we go to Florida. We like to go to the beach.\r\n\r\nMy favorite beach is called Emerson Beach. It is very long, with soft sand and palm trees. It is very beautiful. I like to make sandcastles and watch the sailboats go by. Sometimes there are dolphins and whales in the water!\r\n\r\nEvery morning we look for shells in the sand. I found fifteen big shells last year. I put them in a special place in my room. This year I want to learn to surf. It is hard to surf, but so much fun! My sister is a good surfer. She says that she can teach me. I hope I can do it!", "Our Vacation", new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5685) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedDate", "Email", "FirstName", "IsDelete", "LastName", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5265), "muhammetcagatay@gmail.com", "Muhammet", false, "Çağatay", new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.InsertData(
                table: "Scor",
                columns: new[] { "Id", "AccuracyRate", "CreatedDate", "FalseWord", "IsDelete", "TextId", "TrueWord", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 50.0, new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5699), 20, false, 1, 20, new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5700), 1 },
                    { 2, 60.0, new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5703), 20, false, 2, 30, new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5704), 1 },
                    { 3, 20.0, new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5705), 40, false, 3, 10, new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5706), 1 },
                    { 4, 100.0, new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5706), 0, false, 4, 20, new DateTime(2023, 1, 5, 23, 0, 5, 216, DateTimeKind.Local).AddTicks(5707), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Scor_TextId",
                table: "Scor",
                column: "TextId");

            migrationBuilder.CreateIndex(
                name: "IX_Scor_UserId",
                table: "Scor",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scor");

            migrationBuilder.DropTable(
                name: "Text");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
