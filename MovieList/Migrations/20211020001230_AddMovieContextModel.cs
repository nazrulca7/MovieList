using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieList.Migrations
{
    public partial class AddMovieContextModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(maxLength: 60, nullable: false),
                    MainStar = table.Column<string>(maxLength: 60, nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Ishorror = table.Column<int>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false),
                    Website = table.Column<string>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    GenreId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Name" },
                values: new object[,]
                {
                    { "A", "Action" },
                    { "C", "Comedy" },
                    { "D", "Drama" },
                    { "H", "Horror" },
                    { "M", "Musical" },
                    { "R", "RomCom" },
                    { "S", "SciFi" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "EmailAddress", "GenreId", "Ishorror", "MainStar", "MovieName", "Rating", "Website", "Year" },
                values: new object[] { 2, "a@gmail.com", "A", 0, "Mr 1", "Wonder Woman", 3, "www.url.com", 2017 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "EmailAddress", "GenreId", "Ishorror", "MainStar", "MovieName", "Rating", "Website", "Year" },
                values: new object[] { 4, "a@gmail.com", "D", 0, "Mr 1", "Casablanca", 5, "www .url.com", 1943 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "EmailAddress", "GenreId", "Ishorror", "MainStar", "MovieName", "Rating", "Website", "Year" },
                values: new object[] { 3, "a@gmail.com", "R", 0, "Mr 1", "Moonstruck", 4, "www.url.com", 1988 });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
