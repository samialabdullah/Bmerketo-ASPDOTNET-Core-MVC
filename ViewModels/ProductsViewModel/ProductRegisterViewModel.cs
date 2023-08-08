using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using WebApp.Models.Entities;

namespace WebApp.ViewModels.ProductsViewModel;

public class ProductRegisterViewModel
{
    [Display(Name = "Product Name*")]
    [Required(ErrorMessage = "Please enter the Product Name.")]
    public string Name { get; set; } = null!;

    [Display(Name = "Product Description")]
    public string? Description { get; set; }

    [Display(Name = "Product Price*")]
    [Required(ErrorMessage = "Please enter the Product Price.")]
    [DataType(DataType.Currency)]
    public decimal Prise { get; set; }

    [Display(Name = "Product Category*")]
    [Required(ErrorMessage = "Please enter the Product Category.")]
    public string Category { get; set; } = null!;

    [Display(Name = "Tags Options")]
    public List<string>? Options { get; set; }


    public static implicit operator ProductEntity(ProductRegisterViewModel productRegisterViewModel)
    {
        var productOptions = productRegisterViewModel.Options?.Select(option => new ProductOptionsEntity
        {
            TagName = option
        }).ToList();

        return new ProductEntity
        {
            Name = productRegisterViewModel.Name,
            Description = productRegisterViewModel.Description,
            Price = productRegisterViewModel.Prise,
            Category = productRegisterViewModel.Category,
        };
    }

}



