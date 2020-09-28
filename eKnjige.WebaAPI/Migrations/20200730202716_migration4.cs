using Microsoft.EntityFrameworkCore.Migrations;

namespace eKnjige.WebaAPI.Migrations
{
    public partial class migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrijedlogKnjiga_Klijenti_AdministratorID",
                table: "PrijedlogKnjiga");

            migrationBuilder.DropIndex(
                name: "IX_PrijedlogKnjiga_AdministratorID",
                table: "PrijedlogKnjiga");

            migrationBuilder.DropColumn(
                name: "AdministratorID",
                table: "PrijedlogKnjiga");

            migrationBuilder.DropColumn(
                name: "Prihvacen",
                table: "PrijedlogKnjiga");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdministratorID",
                table: "PrijedlogKnjiga",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Prihvacen",
                table: "PrijedlogKnjiga",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_PrijedlogKnjiga_AdministratorID",
                table: "PrijedlogKnjiga",
                column: "AdministratorID");

            migrationBuilder.AddForeignKey(
                name: "FK_PrijedlogKnjiga_Klijenti_AdministratorID",
                table: "PrijedlogKnjiga",
                column: "AdministratorID",
                principalTable: "Klijenti",
                principalColumn: "KlijentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
