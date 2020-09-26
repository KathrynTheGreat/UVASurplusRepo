using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UVASurplus.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequesterName = table.Column<string>(maxLength: 50, nullable: false),
                    ComputingID = table.Column<string>(maxLength: 10, nullable: false),
                    RequesterEmail = table.Column<string>(maxLength: 50, nullable: false),
                    RequesterDepartment = table.Column<string>(nullable: true),
                    RequesterPhoneNumber = table.Column<string>(nullable: true),
                    RequesterBuilding = table.Column<string>(nullable: true),
                    RequesterRoom = table.Column<string>(nullable: true),
                    DesiredDate = table.Column<DateTime>(nullable: false),
                    AdditionalComments = table.Column<string>(nullable: true),
                    NeedPickup = table.Column<bool>(nullable: false),
                    OProject = table.Column<int>(nullable: false),
                    OTask = table.Column<int>(nullable: false),
                    OAward = table.Column<int>(nullable: false),
                    OOrg = table.Column<int>(nullable: false),
                    TaggedAssets = table.Column<bool>(nullable: false),
                    HealthFunds = table.Column<bool>(nullable: false),
                    RequestDate = table.Column<DateTime>(nullable: false),
                    AdditionalReviewer = table.Column<bool>(nullable: false),
                    AdditionalReviewerCompID = table.Column<string>(nullable: true),
                    RequestStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "item",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestID = table.Column<int>(nullable: false),
                    AssetTag = table.Column<int>(nullable: false),
                    ItemType = table.Column<string>(nullable: true),
                    ItemDescription = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Condition = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    Serial = table.Column<string>(nullable: true),
                    EquipmentType = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item", x => x.ID);
                    table.ForeignKey(
                        name: "FK_item_Request_RequestID",
                        column: x => x.RequestID,
                        principalTable: "Request",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_item_RequestID",
                table: "item",
                column: "RequestID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "item");

            migrationBuilder.DropTable(
                name: "Request");
        }
    }
}
