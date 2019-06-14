using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDesk30.Migrations
{
    public partial class Yo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "surfaceMaterial",
                table: "Desk");

            migrationBuilder.AddColumn<int>(
                name: "newMaterialID",
                table: "Desk",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Desk_newMaterialID",
                table: "Desk",
                column: "newMaterialID");

            migrationBuilder.AddForeignKey(
                name: "FK_Desk_Material_1_newMaterialID",
                table: "Desk",
                column: "newMaterialID",
                principalTable: "Material_1",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Desk_Material_1_newMaterialID",
                table: "Desk");

            migrationBuilder.DropIndex(
                name: "IX_Desk_newMaterialID",
                table: "Desk");

            migrationBuilder.DropColumn(
                name: "newMaterialID",
                table: "Desk");

            migrationBuilder.AddColumn<int>(
                name: "surfaceMaterial",
                table: "Desk",
                nullable: false,
                defaultValue: 0);
        }
    }
}
