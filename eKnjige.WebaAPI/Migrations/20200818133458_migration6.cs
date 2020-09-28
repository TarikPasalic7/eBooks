using Microsoft.EntityFrameworkCore.Migrations;

namespace eKnjige.WebaAPI.Migrations
{
    public partial class migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PogledaoKorisnik",
                table: "PrijedlogKnjiga",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PogledaoKorisnik",
                table: "PrijedlogKnjiga");
        }
    }
}
