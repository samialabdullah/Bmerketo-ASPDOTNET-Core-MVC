using Microsoft.EntityFrameworkCore;
using WebApp.Contexts;
using WebApp.Models;
using WebApp.Models.Entities;
using WebApp.ViewModels.ProductsViewModel;

namespace WebApp.Services;

public class ProductService
{
    private readonly DataContext _context;

    public ProductService(DataContext context)
    {
        _context = context;
    }

    public async Task<bool> RegisterAsync(ProductRegisterViewModel productRegisterViewModel)
    {
        try
        {
            ProductEntity productEntity = productRegisterViewModel;
            _context.Products.Add(productEntity);
            await _context.SaveChangesAsync();
            return true;
        }
        catch 
        {
            return false;
        }
    }

    public async Task<ProductModel> GetAsync(int id)
    {
        try
        {
            var productEntity = await _context.Products.FindAsync(id);

            if (productEntity == null)
            {
                return null!;
            }

            ProductModel productModel = productEntity;
            return productModel;
        }
        catch
        {
            return null!;
        }
    }

    public async Task<IEnumerable<ProductModel>> GetAllAsync()
    {
        var products = new List<ProductModel>();
        var items = await _context.Products.ToListAsync();

        foreach (var item in items)
        {
            ProductModel productModel = item;

            products.Add(productModel);
        }

        return products;
    }
}


