using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_ticket.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorsMovies_Actors_ActorId",
                table: "ActorsMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_ActorsMovies_Movies_MovieId",
                table: "ActorsMovies");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Movies",
                newName: "MovieStatus");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "ActorsMovies",
                newName: "MoviesId");

            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "ActorsMovies",
                newName: "ActorsId");

            migrationBuilder.RenameIndex(
                name: "IX_ActorsMovies_MovieId",
                table: "ActorsMovies",
                newName: "IX_ActorsMovies_MoviesId");

            migrationBuilder.RenameIndex(
                name: "IX_ActorsMovies_ActorId",
                table: "ActorsMovies",
                newName: "IX_ActorsMovies_ActorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorsMovies_Actors_ActorsId",
                table: "ActorsMovies",
                column: "ActorsId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActorsMovies_Movies_MoviesId",
                table: "ActorsMovies",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorsMovies_Actors_ActorsId",
                table: "ActorsMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_ActorsMovies_Movies_MoviesId",
                table: "ActorsMovies");

            migrationBuilder.RenameColumn(
                name: "MovieStatus",
                table: "Movies",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "MoviesId",
                table: "ActorsMovies",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "ActorsId",
                table: "ActorsMovies",
                newName: "ActorId");

            migrationBuilder.RenameIndex(
                name: "IX_ActorsMovies_MoviesId",
                table: "ActorsMovies",
                newName: "IX_ActorsMovies_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_ActorsMovies_ActorsId",
                table: "ActorsMovies",
                newName: "IX_ActorsMovies_ActorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorsMovies_Actors_ActorId",
                table: "ActorsMovies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActorsMovies_Movies_MovieId",
                table: "ActorsMovies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
