using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMVC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemIngredients_Items_ItemId",
                table: "ItemIngredients");

            migrationBuilder.DropIndex(
                name: "IX_ItemIngredients_ItemId",
                table: "ItemIngredients");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "ItemIngredients");

            migrationBuilder.CreateIndex(
                name: "IX_ItemIngredients_ItemRef",
                table: "ItemIngredients",
                column: "ItemRef");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemIngredients_Items_ItemRef",
                table: "ItemIngredients",
                column: "ItemRef",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemIngredients_Items_ItemRef",
                table: "ItemIngredients");

            migrationBuilder.DropIndex(
                name: "IX_ItemIngredients_ItemRef",
                table: "ItemIngredients");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "ItemIngredients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemIngredients_ItemId",
                table: "ItemIngredients",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemIngredients_Items_ItemId",
                table: "ItemIngredients",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id");
        }
    }
}
