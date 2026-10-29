using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JustiPhiSite.Server.Database;

namespace JustiPhiSite.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiceController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetServices")]
        public async Task<IActionResult> GetServices()
        {
            var services = await _context.Services
                .Where(x => x.IsActive)
                .OrderBy(x => x.ServiceCategoryID)
                .ThenBy(x => x.ServiceID)
                .Select(x => new ServiceDto(x.ServiceID, x.Name, x.Description, x.Price, x.ServiceCategoryID))
                .ToListAsync();

            return Ok(services);
        }

        [HttpGet("categories", Name = "GetServiceCategories")]
        public async Task<IActionResult> GetCategories()
        {
            var serviceCategories = await _context.ServiceCategories
                .Where(x => x.Services.Any(s => s.IsActive))
                .OrderBy(x => x.ServiceCategoryID)
                .Select(x => new ServiceCategoryDto(
                    x.ServiceCategoryID,
                    x.Name,
                    x.Services
                        .Where(s => s.IsActive)
                        .OrderBy(s => s.ServiceID)
                        .Select(s => new ServiceDto(s.ServiceID, s.Name, s.Description, s.Price, s.ServiceCategoryID))
                        .ToList()))
                .ToListAsync();

            return Ok(serviceCategories);
        }

        public record ServiceDto(int ServiceID, string Name, string? Description, decimal Price, int ServiceCategoryID);

        public record ServiceCategoryDto(int ServiceCategoryID, string Name, List<ServiceDto> Services);
    }
}
