namespace JustiPhiSite.Server.Database.Models
{
    public class ServiceCategory
    {
        public int ServiceCategoryID { get; set; }
        public string Name { get; set; }

        public List<Service> Services { get; set; } = new List<Service>();
    }
}
