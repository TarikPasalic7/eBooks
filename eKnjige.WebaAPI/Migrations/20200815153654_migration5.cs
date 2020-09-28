using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eKnjige.WebaAPI.Migrations
{
    public partial class migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EKnjigaTipovi");

            migrationBuilder.DropTable(
                name: "KlijentKnjigaOcijene");

            migrationBuilder.DropTable(
                name: "TipFajlova");

            migrationBuilder.DropColumn(
                name: "Jmbg",
                table: "Klijenti");

            migrationBuilder.AddColumn<string>(
                name: "Opis",
                table: "PrijedlogKnjiga",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pdffile",
                table: "EKnjige",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mp3file",
                table: "EKnjige",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "KlijentKnjigaOcjene",
                columns: table => new
                {
                    KlijentKnjigaOcijenaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumOcijene = table.Column<DateTime>(nullable: false),
                    Ocjena = table.Column<float>(nullable: false),
                    KlijentID = table.Column<int>(nullable: false),
                    EKnjigaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KlijentKnjigaOcjene", x => x.KlijentKnjigaOcijenaID);
                    table.ForeignKey(
                        name: "FK_KlijentKnjigaOcjene_EKnjige_EKnjigaID",
                        column: x => x.EKnjigaID,
                        principalTable: "EKnjige",
                        principalColumn: "EKnjigaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KlijentKnjigaOcjene_Klijenti_KlijentID",
                        column: x => x.KlijentID,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KlijentKnjigaOcjene_EKnjigaID",
                table: "KlijentKnjigaOcjene",
                column: "EKnjigaID");

            migrationBuilder.CreateIndex(
                name: "IX_KlijentKnjigaOcjene_KlijentID",
                table: "KlijentKnjigaOcjene",
                column: "KlijentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KlijentKnjigaOcjene");

            migrationBuilder.DropColumn(
                name: "Opis",
                table: "PrijedlogKnjiga");

            migrationBuilder.AddColumn<string>(
                name: "Jmbg",
                table: "Klijenti",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Pdffile",
                table: "EKnjige",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Mp3file",
                table: "EKnjige",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "KlijentKnjigaOcijene",
                columns: table => new
                {
                    KlijentKnjigaOcijenaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumOcijene = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EKnjigaID = table.Column<int>(type: "int", nullable: false),
                    KlijentID = table.Column<int>(type: "int", nullable: false),
                    Ocjena = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KlijentKnjigaOcijene", x => x.KlijentKnjigaOcijenaID);
                    table.ForeignKey(
                        name: "FK_KlijentKnjigaOcijene_EKnjige_EKnjigaID",
                        column: x => x.EKnjigaID,
                        principalTable: "EKnjige",
                        principalColumn: "EKnjigaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KlijentKnjigaOcijene_Klijenti_KlijentID",
                        column: x => x.KlijentID,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipFajlova",
                columns: table => new
                {
                    TipFajlaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipFajlova", x => x.TipFajlaID);
                });

            migrationBuilder.CreateTable(
                name: "EKnjigaTipovi",
                columns: table => new
                {
                    EKnjigaTipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EKnjigaID = table.Column<int>(type: "int", nullable: false),
                    TipFajlaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EKnjigaTipovi", x => x.EKnjigaTipID);
                    table.ForeignKey(
                        name: "FK_EKnjigaTipovi_EKnjige_EKnjigaID",
                        column: x => x.EKnjigaID,
                        principalTable: "EKnjige",
                        principalColumn: "EKnjigaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EKnjigaTipovi_TipFajlova_TipFajlaID",
                        column: x => x.TipFajlaID,
                        principalTable: "TipFajlova",
                        principalColumn: "TipFajlaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EKnjigaTipovi_EKnjigaID",
                table: "EKnjigaTipovi",
                column: "EKnjigaID");

            migrationBuilder.CreateIndex(
                name: "IX_EKnjigaTipovi_TipFajlaID",
                table: "EKnjigaTipovi",
                column: "TipFajlaID");

            migrationBuilder.CreateIndex(
                name: "IX_KlijentKnjigaOcijene_EKnjigaID",
                table: "KlijentKnjigaOcijene",
                column: "EKnjigaID");

            migrationBuilder.CreateIndex(
                name: "IX_KlijentKnjigaOcijene_KlijentID",
                table: "KlijentKnjigaOcijene",
                column: "KlijentID");
        }
    }
}
