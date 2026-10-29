using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JustiPhiSite.Server.Migrations
{
    /// <inheritdoc />
    public partial class DisableNonPrintingServices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Services",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 3,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 4,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 5,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 6,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 7,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 8,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 9,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 10,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 11,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 12,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 13,
                columns: new[] { "Description", "IsActive" },
                values: new object[] { "<p>Now in <strong>Open Beta</strong>. Level up printer maintenance with scheduled maintenance scheduling and part inventory tracking! Request to join the closed beta by sending details on your printer setup.</p><ul><li>List and organise printers by type and location</li><li>Track printer repairs and maintenance</li><li>Track spare part inventory</li><li>Track maintenance and be notified when it is due</li></ul>", true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Services");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 13,
                column: "Description",
                value: "<p>Now in <strong>Open Beta</strong> Level up printer maintenance with scheduled maintenance scheduling and part inventory tracking! Request to join the closed beta by sending details on your printer setup.</p><ul><li>List and organise printers by type and location</li><li>Track printer repairs and maintenance</li><li>Track spare part inventory</li><li>Track maintenace and be notified when it is due</li></ul>");
        }
    }
}
