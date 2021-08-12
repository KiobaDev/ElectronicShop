using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class AddSeedMethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ElectricScooterModel",
                columns: new[] { "ElectricScooterId", "AvaliableAmountId", "AvaliableScooterAmount", "EnginePower", "MaxSpeed", "MaximumLoad", "RangeOnASingleCharge", "ScooterAdditionalNotes", "ScooterName", "ScooterPrice", "TheSizeOfTheWheels" },
                values: new object[] { 1, 1, 0, 250, 25, 100, 25, "Impulse to hulajnoga elektryczna dla młodzieży i dorosłych. Waży 11,8kg posiada 8,5 calowe kola z pompowanymi oponami, które gwarantują swobodę poruszania", "FRUGAL Impulse", 999.99m, 8.5 });

            migrationBuilder.InsertData(
                table: "AvaliableAmount",
                columns: new[] { "AvaliableAmountId", "Amount", "ElectricScooterId" },
                values: new object[] { 1, 56, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AvaliableAmount",
                keyColumn: "AvaliableAmountId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ElectricScooterModel",
                keyColumn: "ElectricScooterId",
                keyValue: 1);
        }
    }
}
