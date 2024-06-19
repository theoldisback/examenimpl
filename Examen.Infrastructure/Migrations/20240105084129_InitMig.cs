using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "concours",
                columns: table => new
                {
                    promotion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NbrEM = table.Column<int>(type: "int", nullable: false),
                    NbrGC = table.Column<int>(type: "int", nullable: false),
                    NbrGED = table.Column<int>(type: "int", nullable: false),
                    Nbrlangue = table.Column<int>(type: "int", nullable: false),
                    NbrMath = table.Column<int>(type: "int", nullable: false),
                    NbrTIC = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_concours", x => x.promotion);
                });

            migrationBuilder.CreateTable(
                name: "uPs",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsable = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uPs", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Enseignants",
                columns: table => new
                {
                    Matricule = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    Specialite = table.Column<int>(type: "int", nullable: false),
                    UPCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UPFK = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enseignants", x => x.Matricule);
                    table.ForeignKey(
                        name: "FK_Enseignants_uPs_UPCode",
                        column: x => x.UPCode,
                        principalTable: "uPs",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "candidatures",
                columns: table => new
                {
                    EnseignantFk = table.Column<int>(type: "int", nullable: false),
                    ConcoursFK = table.Column<int>(type: "int", nullable: false),
                    DateDepot = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEntretien = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEpreuve = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dossier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resultat = table.Column<bool>(type: "bit", nullable: false),
                    Score = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidatures", x => new { x.EnseignantFk, x.ConcoursFK });
                    table.ForeignKey(
                        name: "FK_candidatures_Enseignants_EnseignantFk",
                        column: x => x.EnseignantFk,
                        principalTable: "Enseignants",
                        principalColumn: "Matricule",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_candidatures_concours_ConcoursFK",
                        column: x => x.ConcoursFK,
                        principalTable: "concours",
                        principalColumn: "promotion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_candidatures_ConcoursFK",
                table: "candidatures",
                column: "ConcoursFK");

            migrationBuilder.CreateIndex(
                name: "IX_Enseignants_UPCode",
                table: "Enseignants",
                column: "UPCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "candidatures");

            migrationBuilder.DropTable(
                name: "Enseignants");

            migrationBuilder.DropTable(
                name: "concours");

            migrationBuilder.DropTable(
                name: "uPs");
        }
    }
}
