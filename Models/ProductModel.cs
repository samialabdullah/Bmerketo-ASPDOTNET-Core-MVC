using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using WebApp.Models.Entities;

namespace WebApp.Models
{
    public class ProductModel
    {   
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; } = null!;

    }
}



