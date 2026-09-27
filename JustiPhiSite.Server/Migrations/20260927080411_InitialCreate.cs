using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JustiPhiSite.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceCategories",
                columns: table => new
                {
                    ServiceCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCategories", x => x.ServiceCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ServiceCategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceID);
                    table.ForeignKey(
                        name: "FK_Services_ServiceCategories_ServiceCategoryID",
                        column: x => x.ServiceCategoryID,
                        principalTable: "ServiceCategories",
                        principalColumn: "ServiceCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ServiceCategories",
                columns: new[] { "ServiceCategoryID", "Name" },
                values: new object[,]
                {
                    { 1, "3D Printing" },
                    { 2, "IT Support" },
                    { 3, "Software Development" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceID", "Description", "Name", "Price", "ServiceCategoryID" },
                values: new object[,]
                {
                    { 1, "<p>Full maintenance and repair of <strong>FDM and resin</strong> 3D printers, including:</p><ul><li>Diagnosing print quality issues</li><li>Replacing worn or broken parts such as nozzles, belts, hotends and build plates</li><li>Bed levelling and extrusion calibration</li><li>Firmware updates</li></ul><p>I can also provide hands-on training so you know how to use and look after your printer properly.</p>", "Printer Maintenance", 0m, 1 },
                    { 2, "<p>Strong, functional <strong>FDM</strong> parts printed to order from your own files or from designs found online, in a wide range of colours and materials:</p><ul><li>PLA</li><li>PETG</li><li>ABS</li><li>TPU (flexible)</li></ul><p>I'll advise on the best material, infill and orientation for strength and finish. <strong>Multi-colour printing is available at an additional cost.</strong></p>", "FDM Printing", 0m, 1 },
                    { 3, "<p>Custom 3D models designed from:</p><ul><li>Sketches or drawings</li><li>Measurements</li><li>Photos</li><li>An existing part that needs replacing</li></ul><p>Models are designed with printing in mind and can be supplied as <strong>print-ready files</strong> or printed for you.</p>", "3D Modelling", 0m, 1 },
                    { 4, "<p>Rapid prototyping for inventors and small businesses.</p><p>I can take an idea through several design and print iterations <strong>quickly and affordably</strong>, so you can test fit, form and function before committing to manufacturing.</p>", "Prototyping", 0m, 1 },
                    { 5, "<p>Diagnosis and repair of <strong>desktop PCs</strong>, including:</p><ul><li>Hardware replacement</li><li>Upgrades such as extra RAM or a faster SSD</li><li>Fixing slow or unstable systems</li></ul>", "Desktop PC Repair", 0m, 2 },
                    { 6, "<p>Removal of viruses, malware and unwanted software.</p><p>Every clean-up is followed by a <strong>security check-up</strong> and the setup of protection to help keep your computer safe in future.</p>", "Virus Removal", 0m, 2 },
                    { 7, "<p>Setup and troubleshooting of home and small office networks, including:</p><ul><li>Routers</li><li>Wi-Fi coverage</li><li>Printers</li><li>Shared storage</li></ul><p>So all your devices connect <strong>reliably and securely</strong>.</p>", "Network Setup", 0m, 2 },
                    { 8, "<p>Recovery of lost or deleted files from:</p><ul><li>Failing hard drives and SSDs</li><li>USB sticks</li><li>Memory cards</li></ul><p>Plus help <strong>setting up backups</strong> so it doesn't happen again.</p>", "Data Recovery", 0m, 2 },
                    { 9, "<p>Design and development of modern, <strong>responsive</strong> websites and web applications, from simple business sites to full applications with databases and user accounts.</p>", "Web Development", 0m, 3 },
                    { 10, "<p>Bespoke software built around your needs, such as:</p><ul><li>Desktop tools</li><li>Automation scripts</li><li>Integrations between systems</li></ul><p>Save time by removing repetitive manual work.</p>", "Custom Software", 0m, 3 },
                    { 11, "<p>Design, setup and optimisation of databases.</p><p>I can move your data <strong>out of spreadsheets</strong> into a properly structured database that is easier to search, report on and maintain.</p>", "Database Design", 0m, 3 },
                    { 12, "<p>High-detail <strong>resin (MSLA)</strong> printing for parts where fine detail and a smooth surface finish matter, such as:</p><ul><li>Miniatures, figurines and tabletop models</li><li>Display pieces and scale models</li><li>Small precision parts and detailed prototypes</li><li>Jewellery and craft masters</li></ul><p>Every print is <strong>washed, UV-cured and has its supports removed and cleaned up</strong>, so it arrives ready to paint or use.</p>", "Resin Printing", 0m, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceCategoryID",
                table: "Services",
                column: "ServiceCategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "ServiceCategories");
        }
    }
}
