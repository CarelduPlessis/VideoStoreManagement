using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoStoreManagement.Migrations
{
    public partial class VideoStoreMDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Release = table.Column<DateTime>(nullable: false),
                    Copies = table.Column<int>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieRental",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateIsued = table.Column<DateTime>(nullable: false),
                    DateReterned = table.Column<DateTime>(nullable: false),
                    IsMovieLateReturned = table.Column<bool>(nullable: false),
                    MovieFK = table.Column<int>(nullable: false),
                    CustomerFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieRental", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieRental_Customer_CustomerFK",
                        column: x => x.CustomerFK,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieRental_Movie_MovieFK",
                        column: x => x.MovieFK,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieRental_CustomerFK",
                table: "MovieRental",
                column: "CustomerFK");

            migrationBuilder.CreateIndex(
                name: "IX_MovieRental_MovieFK",
                table: "MovieRental",
                column: "MovieFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieRental");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
