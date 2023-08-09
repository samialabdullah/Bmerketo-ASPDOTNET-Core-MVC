using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebApp.Services;
using WebApp.ViewModels;
using WebApp.ViewModels.ProductsViewModel;

namespace WebApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "Products";

            return View();

        }

        public IActionResult Details(int id)
        {
            if (id == 0)
            {
                return RedirectToAction("index", "home");
            }

            ViewData["Title"] = "Product Details";
            return View();
        }

        public IActionResult CreateProducts()
        {
            ViewData["Title"] = "Create Products";
            return View();
        }

        [Authorize(Roles = "admin")]
        public IActionResult Register()
        {
            ViewData["Title"] = "Register Products";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(ProductRegisterViewModel productRegisterViewModel)
        {
            ViewData["Title"] = "Register Product";

            if (ModelState.IsValid)
            {
                try
                {
                    if (await _productService.CreateAsync(productRegisterViewModel))
                        return RedirectToAction("register", "products");
                    else
                        ModelState.AddModelError("", "Something went wrong while creating the Product.");
                }
                catch
                {
                    ModelState.AddModelError("", "Something went wrong while creating the Product.");
                }

            }

            return View(productRegisterViewModel);

        }



    }
}

