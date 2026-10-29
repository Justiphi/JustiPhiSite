using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JustiPhiSite.Server.Migrations
{
    /// <inheritdoc />
    public partial class LayerZeroFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 13,
                column: "Description",
                value: "<p>Now in <strong>Closed Beta</strong>. Level up printer maintenance with scheduled maintenance scheduling and part inventory tracking! Request to join the closed beta by sending details on your printer setup.</p><ul><li>List and organise printers by type and location</li><li>Track printer repairs and maintenance</li><li>Track spare part inventory</li><li>Track maintenance and be notified when it is due</li></ul>");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 13,
                column: "Description",
                value: "<p>Now in <strong>Open Beta</strong>. Level up printer maintenance with scheduled maintenance scheduling and part inventory tracking! Request to join the closed beta by sending details on your printer setup.</p><ul><li>List and organise printers by type and location</li><li>Track printer repairs and maintenance</li><li>Track spare part inventory</li><li>Track maintenance and be notified when it is due</li></ul>");
        }
    }
}
