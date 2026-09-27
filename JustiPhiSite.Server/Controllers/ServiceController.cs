using Microsoft.AspNetCore.Mvc;
using JustiPhiSite.Server.Database.Models;
using JustiPhiSite.Server.Database;

namespace JustiPhiSite.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetService")]
        public IEnumerable<Service> GetServices()
        {
            List<Service> services = new List<Service>();

            services = _context.Services.OrderByDescending(x => x.Name).ToList();

            return services;
        }

        [HttpGet(Name = "GetServiceCategories")]
        public IEnumerable<ServiceCategory> GetCategories()
        {
            List<ServiceCategory> serviceCategories = new List<ServiceCategory>();

            serviceCategories = _context.ServiceCategories.OrderByDescending(x => x.Name).ToList();

            return serviceCategories;
        }
    }
}
