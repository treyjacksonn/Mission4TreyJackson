using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4TreyJackson.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<string>(nullable: true),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Crime/Drama", "Francis Ford Coppola", "False", "", "Greatest of all time!", "R", "The Godfather", 1972 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "War/Drama", "Sam Mendes", "True", "", "Favorite War Movie", "R", "1917", 2019 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Romance", "Michel Gondry", "False", "", "Favorite Romance", "R", "Eternal Sunshine of the Spotless Mind", 2004 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
