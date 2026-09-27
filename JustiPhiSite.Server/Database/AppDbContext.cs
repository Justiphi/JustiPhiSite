using JustiPhiSite.Server.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace JustiPhiSite.Server.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<ServiceCategory> ServiceCategories { get; set; }
        public DbSet<Service> Services { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<ServiceCategory>().HasData(
                    new ServiceCategory() { ServiceCategoryID = 1, Name = "3D Printing" },
                    new ServiceCategory() { ServiceCategoryID = 2, Name = "IT Support" },
                    new ServiceCategory() { ServiceCategoryID = 3, Name = "Software Development" }
                );

            modelBuilder.Entity<Service>().HasData(
                    new Service() { ServiceID = 1, Name = "Printer Maintenance", Description="<p>Full maintenance and repair of <strong>FDM and resin</strong> 3D printers, including:</p><ul><li>Diagnosing print quality issues</li><li>Replacing worn or broken parts such as nozzles, belts, hotends and build plates</li><li>Bed levelling and extrusion calibration</li><li>Firmware updates</li></ul><p>I can also provide hands-on training so you know how to use and look after your printer properly.</p>", ServiceCategoryID=1 },
                    new Service() { ServiceID = 2, Name = "Part Printing", Description="<p>I can print parts to order from your own files or from designs found online, in a wide range of colours and materials:</p><ul><li>PLA</li><li>PETG</li><li>ABS</li><li>TPU (flexible)</li></ul><p>I'll advise on the best material, infill and orientation for strength and finish. <strong>Multi-colour printing is available at an additional cost.</strong></p>", ServiceCategoryID=1 },
                    new Service() { ServiceID = 3, Name = "3D Modelling", Description="<p>Custom 3D models designed from:</p><ul><li>Sketches or drawings</li><li>Measurements</li><li>Photos</li><li>An existing part that needs replacing</li></ul><p>Models are designed with printing in mind and can be supplied as <strong>print-ready files</strong> or printed for you.</p>", ServiceCategoryID=1 },
                    new Service() { ServiceID = 4, Name = "Prototyping", Description="<p>Rapid prototyping for inventors and small businesses.</p><p>I can take an idea through several design and print iterations <strong>quickly and affordably</strong>, so you can test fit, form and function before committing to manufacturing.</p>", ServiceCategoryID=1 },
                    new Service() { ServiceID = 5, Name = "Computer Repair", Description="<p>Diagnosis and repair of desktop and laptop computers, including:</p><ul><li>Hardware replacement</li><li>Upgrades such as extra RAM or a faster SSD</li><li>Fixing slow or unstable systems</li></ul>", ServiceCategoryID=2 },
                    new Service() { ServiceID = 6, Name = "Virus Removal", Description="<p>Removal of viruses, malware and unwanted software.</p><p>Every clean-up is followed by a <strong>security check-up</strong> and the setup of protection to help keep your computer safe in future.</p>", ServiceCategoryID=2 },
                    new Service() { ServiceID = 7, Name = "Network Setup", Description="<p>Setup and troubleshooting of home and small office networks, including:</p><ul><li>Routers</li><li>Wi-Fi coverage</li><li>Printers</li><li>Shared storage</li></ul><p>So all your devices connect <strong>reliably and securely</strong>.</p>", ServiceCategoryID=2 },
                    new Service() { ServiceID = 8, Name = "Data Recovery", Description="<p>Recovery of lost or deleted files from:</p><ul><li>Failing hard drives and SSDs</li><li>USB sticks</li><li>Memory cards</li></ul><p>Plus help <strong>setting up backups</strong> so it doesn't happen again.</p>", ServiceCategoryID=2 },
                    new Service() { ServiceID = 9, Name = "Web Development", Description="<p>Design and development of modern, <strong>responsive</strong> websites and web applications, from simple business sites to full applications with databases and user accounts.</p>", ServiceCategoryID=3 },
                    new Service() { ServiceID = 10, Name = "Custom Software", Description="<p>Bespoke software built around your needs, such as:</p><ul><li>Desktop tools</li><li>Automation scripts</li><li>Integrations between systems</li></ul><p>Save time by removing repetitive manual work.</p>", ServiceCategoryID=3 },
                    new Service() { ServiceID = 11, Name = "Database Design", Description="<p>Design, setup and optimisation of databases.</p><p>I can move your data <strong>out of spreadsheets</strong> into a properly structured database that is easier to search, report on and maintain.</p>", ServiceCategoryID=3 }
                );
        }
    }
}
