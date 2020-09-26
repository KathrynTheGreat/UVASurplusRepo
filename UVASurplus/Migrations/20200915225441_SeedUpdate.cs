using Microsoft.EntityFrameworkCore.Migrations;

namespace UVASurplus.Migrations
{
    public partial class SeedUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_item_Request_RequestID",
                table: "item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_item",
                table: "item");

            migrationBuilder.RenameTable(
                name: "item",
                newName: "Item");

            migrationBuilder.RenameIndex(
                name: "IX_item_RequestID",
                table: "Item",
                newName: "IX_Item_RequestID");

            migrationBuilder.AlterColumn<string>(
                name: "RequestStatus",
                table: "Request",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Request_RequestID",
                table: "Item",
                column: "RequestID",
                principalTable: "Request",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Request_RequestID",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "item");

            migrationBuilder.RenameIndex(
                name: "IX_Item_RequestID",
                table: "item",
                newName: "IX_item_RequestID");

            migrationBuilder.AlterColumn<bool>(
                name: "RequestStatus",
                table: "Request",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_item",
                table: "item",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_item_Request_RequestID",
                table: "item",
                column: "RequestID",
                principalTable: "Request",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
