using System.ComponentModel.DataAnnotations.Schema;
namespace WebApp.Models.Entities;

public partial class ProductEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal Price { get; set; }
    public string Category { get; set; } = null!;
    public string? Description { get; set; }

    
    
   



    public static implicit operator ProductModel(ProductEntity productEntity)
    {
        return new ProductModel
        {
            Id = productEntity.Id,
            Name = productEntity.Name,
            Price = productEntity.Price,
            Category = productEntity.Category,
            Description = productEntity.Description,
        };
    }

   
}



