using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JustiPhiSite.Server.Database.Models
{
    public class Service
    {
        [Key]
        public int ServiceID { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(2000)]
        public string? Description { get; set; }

        [Required]
        [Precision(18, 2)]
        public decimal Price { get; set; }

        [Required]
        [ForeignKey(nameof(ServiceCategory.ServiceCategoryID))]
        public int ServiceCategoryID { get; set; }
        public ServiceCategory? ServiceCategory { get; set; }
    }
}
