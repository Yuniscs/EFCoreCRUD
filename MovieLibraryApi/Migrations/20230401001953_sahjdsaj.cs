using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieLibraryApi.Migrations
{
    public partial class sahjdsaj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actorss_Movies_MovieId",
                table: "Actorss");

            migrationBuilder.DropIndex(
                name: "IX_Actorss_MovieId",
                table: "Actorss");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Actorss");

            migrationBuilder.AlterColumn<int>(
                name: "ReleaseYear",
                table: "Movies",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "ActorsMovie",
                columns: table => new
                {
                    ActorssId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorsMovie", x => new { x.ActorssId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_ActorsMovie_Actorss_ActorssId",
                        column: x => x.ActorssId,
                        principalTable: "Actorss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorsMovie_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorsMovie_MoviesId",
                table: "ActorsMovie",
                column: "MoviesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorsMovie");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseYear",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Actorss",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Actorss_MovieId",
                table: "Actorss",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actorss_Movies_MovieId",
                table: "Actorss",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
