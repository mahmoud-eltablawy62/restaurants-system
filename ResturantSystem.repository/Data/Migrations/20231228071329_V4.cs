using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResturantSystem.repository.Data.Migrations
{
    public partial class V4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resturants_Menus_MenusId",
                table: "Resturants");

            migrationBuilder.DropIndex(
                name: "IX_Resturants_MenusId",
                table: "Resturants");

            migrationBuilder.DropColumn(
                name: "MenusId",
                table: "Resturants");

            migrationBuilder.AddColumn<int>(
                name: "ResId",
                table: "Menus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Menus_ResId",
                table: "Menus",
                column: "ResId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Resturants_ResId",
                table: "Menus",
                column: "ResId",
                principalTable: "Resturants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Resturants_ResId",
                table: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_Menus_ResId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "ResId",
                table: "Menus");

            migrationBuilder.AddColumn<int>(
                name: "MenusId",
                table: "Resturants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Resturants_MenusId",
                table: "Resturants",
                column: "MenusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resturants_Menus_MenusId",
                table: "Resturants",
                column: "MenusId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
