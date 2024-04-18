using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Infra.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bungalows",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prix = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NombreChambre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bungalows", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Locataires",
                columns: table => new
                {
                    CIN = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Tel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locataires", x => x.CIN);
                });

            migrationBuilder.CreateTable(
                name: "options",
                columns: table => new
                {
                    OptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrixOption = table.Column<double>(type: "float", nullable: false),
                    bungalowid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_options", x => x.OptionId);
                    table.ForeignKey(
                        name: "FK_options_bungalows_bungalowid",
                        column: x => x.bungalowid,
                        principalTable: "bungalows",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    DateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocataireFK = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BungalowFK = table.Column<int>(type: "int", nullable: false),
                    NombreJour = table.Column<int>(type: "int", nullable: false),
                    saison = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => new { x.DateDebut, x.LocataireFK, x.BungalowFK });
                    table.ForeignKey(
                        name: "FK_Reservations_Locataires_LocataireFK",
                        column: x => x.LocataireFK,
                        principalTable: "Locataires",
                        principalColumn: "CIN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_bungalows_BungalowFK",
                        column: x => x.BungalowFK,
                        principalTable: "bungalows",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_options_bungalowid",
                table: "options",
                column: "bungalowid");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_BungalowFK",
                table: "Reservations",
                column: "BungalowFK");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_LocataireFK",
                table: "Reservations",
                column: "LocataireFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "options");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Locataires");

            migrationBuilder.DropTable(
                name: "bungalows");
        }
    }
}
