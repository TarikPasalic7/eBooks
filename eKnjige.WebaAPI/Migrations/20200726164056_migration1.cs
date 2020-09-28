using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eKnjige.WebaAPI.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autori",
                columns: table => new
                {
                    AutorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Godiste = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autori", x => x.AutorID);
                });

            migrationBuilder.CreateTable(
                name: "Drzave",
                columns: table => new
                {
                    DrzavaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzave", x => x.DrzavaID);
                });

            migrationBuilder.CreateTable(
                name: "Kategorije",
                columns: table => new
                {
                    KategorijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorije", x => x.KategorijaID);
                });

            migrationBuilder.CreateTable(
                name: "Spol",
                columns: table => new
                {
                    SpolID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spol", x => x.SpolID);
                });

            migrationBuilder.CreateTable(
                name: "TipFajlova",
                columns: table => new
                {
                    TipFajlaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipFajlova", x => x.TipFajlaID);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.UlogaId);
                });

            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    DrzavaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gradovi_Drzave_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzave",
                        principalColumn: "DrzavaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Klijenti",
                columns: table => new
                {
                    KlijentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    LozinkaHash = table.Column<string>(nullable: true),
                    LozinkaSalt = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Jmbg = table.Column<string>(nullable: true),
                    DatumRodenja = table.Column<DateTime>(nullable: false),
                    SpolID = table.Column<int>(nullable: false),
                    GradID = table.Column<int>(nullable: false),
                    UlogaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klijenti", x => x.KlijentID);
                    table.ForeignKey(
                        name: "FK_Klijenti_Gradovi_GradID",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Klijenti_Spol_SpolID",
                        column: x => x.SpolID,
                        principalTable: "Spol",
                        principalColumn: "SpolID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Klijenti_Uloge_UlogaID",
                        column: x => x.UlogaID,
                        principalTable: "Uloge",
                        principalColumn: "UlogaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EKnjige",
                columns: table => new
                {
                    EKnjigaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    OcjenaKnjige = table.Column<float>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true),
                    Cijena = table.Column<float>(nullable: false),
                    Mp3file = table.Column<byte[]>(nullable: true),
                    Pdffile = table.Column<byte[]>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    AdministratorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EKnjige", x => x.EKnjigaID);
                    table.ForeignKey(
                        name: "FK_EKnjige_Klijenti_AdministratorID",
                        column: x => x.AdministratorID,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrijedlogKnjiga",
                columns: table => new
                {
                    PrijedlogKnjigeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(nullable: false),
                    Prihvacen = table.Column<bool>(nullable: false),
                    Odgovoren = table.Column<bool>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    KlijentID = table.Column<int>(nullable: false),
                    AdministratorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrijedlogKnjiga", x => x.PrijedlogKnjigeID);
                    table.ForeignKey(
                        name: "FK_PrijedlogKnjiga_Klijenti_AdministratorID",
                        column: x => x.AdministratorID,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrijedlogKnjiga_Klijenti_KlijentID",
                        column: x => x.KlijentID,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EKnjigaAutori",
                columns: table => new
                {
                    EKnjigeAutorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutorID = table.Column<int>(nullable: false),
                    EKnjigaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EKnjigaAutori", x => x.EKnjigeAutorID);
                    table.ForeignKey(
                        name: "FK_EKnjigaAutori_Autori_AutorID",
                        column: x => x.AutorID,
                        principalTable: "Autori",
                        principalColumn: "AutorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EKnjigaAutori_EKnjige_EKnjigaID",
                        column: x => x.EKnjigaID,
                        principalTable: "EKnjige",
                        principalColumn: "EKnjigaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EKnjigaKategorije",
                columns: table => new
                {
                    EKnjigaKategorijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EKnjigaID = table.Column<int>(nullable: false),
                    KategorijaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EKnjigaKategorije", x => x.EKnjigaKategorijaID);
                    table.ForeignKey(
                        name: "FK_EKnjigaKategorije_EKnjige_EKnjigaID",
                        column: x => x.EKnjigaID,
                        principalTable: "EKnjige",
                        principalColumn: "EKnjigaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EKnjigaKategorije_Kategorije_KategorijaID",
                        column: x => x.KategorijaID,
                        principalTable: "Kategorije",
                        principalColumn: "KategorijaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EKnjigaTipovi",
                columns: table => new
                {
                    EKnjigaTipID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EKnjigaID = table.Column<int>(nullable: false),
                    TipFajlaID = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "KlijentKnjigaOcijene",
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
                name: "Komentari",
                columns: table => new
                {
                    KomentarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    komentar = table.Column<string>(nullable: true),
                    DatumKomentara = table.Column<DateTime>(nullable: false),
                    KlijentID = table.Column<int>(nullable: false),
                    EKnjigaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentari", x => x.KomentarId);
                    table.ForeignKey(
                        name: "FK_Komentari_EKnjige_EKnjigaID",
                        column: x => x.EKnjigaID,
                        principalTable: "EKnjige",
                        principalColumn: "EKnjigaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Komentari_Klijenti_KlijentID",
                        column: x => x.KlijentID,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "KupovinaKnjiga",
                columns: table => new
                {
                    KupovinaKnjigeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumKupovine = table.Column<DateTime>(nullable: false),
                    KlijentID = table.Column<int>(nullable: false),
                    EKnjigaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KupovinaKnjiga", x => x.KupovinaKnjigeID);
                    table.ForeignKey(
                        name: "FK_KupovinaKnjiga_EKnjige_EKnjigaID",
                        column: x => x.EKnjigaID,
                        principalTable: "EKnjige",
                        principalColumn: "EKnjigaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KupovinaKnjiga_Klijenti_KlijentID",
                        column: x => x.KlijentID,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EKnjigaAutori_AutorID",
                table: "EKnjigaAutori",
                column: "AutorID");

            migrationBuilder.CreateIndex(
                name: "IX_EKnjigaAutori_EKnjigaID",
                table: "EKnjigaAutori",
                column: "EKnjigaID");

            migrationBuilder.CreateIndex(
                name: "IX_EKnjigaKategorije_EKnjigaID",
                table: "EKnjigaKategorije",
                column: "EKnjigaID");

            migrationBuilder.CreateIndex(
                name: "IX_EKnjigaKategorije_KategorijaID",
                table: "EKnjigaKategorije",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_EKnjigaTipovi_EKnjigaID",
                table: "EKnjigaTipovi",
                column: "EKnjigaID");

            migrationBuilder.CreateIndex(
                name: "IX_EKnjigaTipovi_TipFajlaID",
                table: "EKnjigaTipovi",
                column: "TipFajlaID");

            migrationBuilder.CreateIndex(
                name: "IX_EKnjige_AdministratorID",
                table: "EKnjige",
                column: "AdministratorID");

            migrationBuilder.CreateIndex(
                name: "IX_Gradovi_DrzavaId",
                table: "Gradovi",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Klijenti_GradID",
                table: "Klijenti",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Klijenti_SpolID",
                table: "Klijenti",
                column: "SpolID");

            migrationBuilder.CreateIndex(
                name: "IX_Klijenti_UlogaID",
                table: "Klijenti",
                column: "UlogaID");

            migrationBuilder.CreateIndex(
                name: "IX_KlijentKnjigaOcijene_EKnjigaID",
                table: "KlijentKnjigaOcijene",
                column: "EKnjigaID");

            migrationBuilder.CreateIndex(
                name: "IX_KlijentKnjigaOcijene_KlijentID",
                table: "KlijentKnjigaOcijene",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_Komentari_EKnjigaID",
                table: "Komentari",
                column: "EKnjigaID");

            migrationBuilder.CreateIndex(
                name: "IX_Komentari_KlijentID",
                table: "Komentari",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_KupovinaKnjiga_EKnjigaID",
                table: "KupovinaKnjiga",
                column: "EKnjigaID");

            migrationBuilder.CreateIndex(
                name: "IX_KupovinaKnjiga_KlijentID",
                table: "KupovinaKnjiga",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_PrijedlogKnjiga_AdministratorID",
                table: "PrijedlogKnjiga",
                column: "AdministratorID");

            migrationBuilder.CreateIndex(
                name: "IX_PrijedlogKnjiga_KlijentID",
                table: "PrijedlogKnjiga",
                column: "KlijentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EKnjigaAutori");

            migrationBuilder.DropTable(
                name: "EKnjigaKategorije");

            migrationBuilder.DropTable(
                name: "EKnjigaTipovi");

            migrationBuilder.DropTable(
                name: "KlijentKnjigaOcijene");

            migrationBuilder.DropTable(
                name: "Komentari");

            migrationBuilder.DropTable(
                name: "KupovinaKnjiga");

            migrationBuilder.DropTable(
                name: "PrijedlogKnjiga");

            migrationBuilder.DropTable(
                name: "Autori");

            migrationBuilder.DropTable(
                name: "Kategorije");

            migrationBuilder.DropTable(
                name: "TipFajlova");

            migrationBuilder.DropTable(
                name: "EKnjige");

            migrationBuilder.DropTable(
                name: "Klijenti");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "Spol");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Drzave");
        }
    }
}
