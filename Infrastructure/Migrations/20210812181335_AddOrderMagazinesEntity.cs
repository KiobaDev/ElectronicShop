using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class AddOrderMagazinesEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElectricScooterModels",
                columns: table => new
                {
                    ElectricScooterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScooterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnginePower = table.Column<int>(type: "int", nullable: false),
                    MaxSpeed = table.Column<int>(type: "int", nullable: false),
                    RangeOnASingleCharge = table.Column<int>(type: "int", nullable: false),
                    TheSizeOfTheWheels = table.Column<double>(type: "float", nullable: false),
                    MaximumLoad = table.Column<int>(type: "int", nullable: false),
                    ScooterPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AvaliableScooterAmount = table.Column<int>(type: "int", nullable: false),
                    ScooterAdditionalNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvaliableAmountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricScooterModels", x => x.ElectricScooterId);
                });

            migrationBuilder.CreateTable(
                name: "Magazines",
                columns: table => new
                {
                    MagazineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MagazineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingNumber = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magazines", x => x.MagazineId);
                });

            migrationBuilder.CreateTable(
                name: "AvaliableAmounts",
                columns: table => new
                {
                    AvaliableAmountId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ElectricScooterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaliableAmounts", x => x.AvaliableAmountId);
                    table.ForeignKey(
                        name: "FK_AvaliableAmounts_ElectricScooterModels_AvaliableAmountId",
                        column: x => x.AvaliableAmountId,
                        principalTable: "ElectricScooterModels",
                        principalColumn: "ElectricScooterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MagazineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Magazines_MagazineId",
                        column: x => x.MagazineId,
                        principalTable: "Magazines",
                        principalColumn: "MagazineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricScooterModelOrder",
                columns: table => new
                {
                    ElectricScootersElectricScooterId = table.Column<int>(type: "int", nullable: false),
                    OrdersOrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricScooterModelOrder", x => new { x.ElectricScootersElectricScooterId, x.OrdersOrderId });
                    table.ForeignKey(
                        name: "FK_ElectricScooterModelOrder_ElectricScooterModels_ElectricScootersElectricScooterId",
                        column: x => x.ElectricScootersElectricScooterId,
                        principalTable: "ElectricScooterModels",
                        principalColumn: "ElectricScooterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElectricScooterModelOrder_Orders_OrdersOrderId",
                        column: x => x.OrdersOrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderMagazines",
                columns: table => new
                {
                    MagazineId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderMagazines", x => new { x.OrderId, x.MagazineId });
                    table.ForeignKey(
                        name: "FK_OrderMagazines_Magazines_MagazineId",
                        column: x => x.MagazineId,
                        principalTable: "Magazines",
                        principalColumn: "MagazineId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderMagazines_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElectricScooterModelOrder_OrdersOrderId",
                table: "ElectricScooterModelOrder",
                column: "OrdersOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderMagazines_MagazineId",
                table: "OrderMagazines",
                column: "MagazineId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_MagazineId",
                table: "Orders",
                column: "MagazineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvaliableAmounts");

            migrationBuilder.DropTable(
                name: "ElectricScooterModelOrder");

            migrationBuilder.DropTable(
                name: "OrderMagazines");

            migrationBuilder.DropTable(
                name: "ElectricScooterModels");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Magazines");
        }
    }
}
