using System.ComponentModel.DataAnnotations;
using WebApp.Models.Entities;

namespace WebApp.ViewModels.ProductsViewModel;

public class ProductRegisterViewModel
{
    [Display(Name = "Product-Name*")]
    [Required(ErrorMessage = "Please enter the Product Name.")]
    public string Name { get; set; } = null!;

    [Display(Name = "Product-Price*")]
    [Required(ErrorMessage = "Please enter the Product Price.")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    [Display(Name = "Product-Category*")]
    [Required(ErrorMessage = "Please enter the Product Category.")]
    public string Category { get; set; } = null!;

    [Display(Name = "Product Description")]
    public string? Description { get; set; }








    public static implicit operator ProductEntity(ProductRegisterViewModel productRegisterViewModel)
    {

        return new ProductEntity
        {
            Name = productRegisterViewModel.Name,
            Price = productRegisterViewModel.Price,
            Category = productRegisterViewModel.Category,
            Description = productRegisterViewModel.Description,
            
           
        };
    }

}



