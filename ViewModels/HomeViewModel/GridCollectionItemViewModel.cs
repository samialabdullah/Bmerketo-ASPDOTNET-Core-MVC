using WebApp.Models;
using WebApp.Models.Entities;

namespace WebApp.ViewModels.HomeViewModel
{
    public class GridCollectionItemViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string Category { get; set; } = null!;




        public static implicit operator GridCollectionItemViewModel(ProductEntity productEntity)
        {
            return new GridCollectionItemViewModel
            {
                Id = productEntity.Id,
                Title = productEntity.Name,
                Price = productEntity.Price,
                Description = productEntity.Description,
                Category = productEntity.Category,
            };
        }

    }
}


