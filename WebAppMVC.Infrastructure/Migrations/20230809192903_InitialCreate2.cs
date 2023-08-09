using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMVC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactDetails");

            migrationBuilder.DropTable(
                name: "ContactDetailTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemIngredients",
                table: "ItemIngredients");

            migrationBuilder.RenameColumn(
                name: "NameUser",
                table: "CustomerContactInformactions",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ItemIngredients",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ItemIngredientsId",
                table: "ItemIngredients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AddressEmail",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNubmer",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemIngredients",
                table: "ItemIngredients",
                columns: new[] { "ItemIngredientsId", "ItemRef" });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ItemIngredients_Ingredients_ItemIngredientsId",
                table: "ItemIngredients",
                column: "ItemIngredientsId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemIngredients_Ingredients_ItemIngredientsId",
                table: "ItemIngredients");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemIngredients",
                table: "ItemIngredients");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemIngredientsId",
                table: "ItemIngredients");

            migrationBuilder.DropColumn(
                name: "AddressEmail",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneNubmer",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "CustomerContactInformactions",
                newName: "NameUser");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ItemIngredients",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemIngredients",
                table: "ItemIngredients",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ContactDetailTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDetailTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactDetails",
                columns: table => new
                {
                    ContactDetailTypeId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ContactDetailInformaction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDetails", x => new { x.ContactDetailTypeId, x.CustomerId });
                    table.ForeignKey(
                        name: "FK_ContactDetails_ContactDetailTypes_ContactDetailTypeId",
                        column: x => x.ContactDetailTypeId,
                        principalTable: "ContactDetailTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactDetails_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetails_CustomerId",
                table: "ContactDetails",
                column: "CustomerId");
        }
    }
}
