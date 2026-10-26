using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JustiPhiSite.Server.Migrations
{
    /// <inheritdoc />
    public partial class LayerZero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ServiceCategories",
                columns: new[] { "ServiceCategoryID", "Name" },
                values: new object[] { 4, "Software Solutions" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceID", "Description", "Name", "Price", "ServiceCategoryID" },
                values: new object[] { 13, "<p>Now in <strong>Open Beta</strong> Level up printer maintenance with scheduled maintenance scheduling and part inventory tracking! Request to join the closed beta by sending details on your printer setup.</p><ul><li>List and organise printers by type and location</li><li>Track printer repairs and maintenance</li><li>Track spare part inventory</li><li>Track maintenace and be notified when it is due</li></ul>", "Layer Zero", 0m, 4 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "ServiceCategoryID",
                keyValue: 4);
        }
    }
}
