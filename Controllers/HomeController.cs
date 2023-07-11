using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new HomeIndexViewModel
            {
                BestCollection = new GridCollectionViewModel
                {
                    Title = "Best Collection",
                    Categories = new List<string> { "All", "Bag", "Dress", "Decoration", "Essentials", "Interior", "Laptops", "Mobile", "Beauty" },
                    GridItems = new List<GridCollectionItemViewModel>
                    {
                        new GridCollectionItemViewModel { Id = "1" , Title = "Apple watch collection", Price = 10, ImageUrl = "images/placeholders/270x295.svg" },
                        new GridCollectionItemViewModel { Id = "2" , Title = "Apple watch collection", Price = 20, ImageUrl = "images/placeholders/270x295.svg" },
                        new GridCollectionItemViewModel { Id = "3" , Title = "Apple watch collection", Price = 30, ImageUrl = "images/placeholders/270x295.svg" },
                        new GridCollectionItemViewModel { Id = "4" , Title = "Apple watch collection", Price = 40, ImageUrl = "images/placeholders/270x295.svg" },
                        new GridCollectionItemViewModel { Id = "5" , Title = "Apple watch collection", Price = 50, ImageUrl = "images/placeholders/270x295.svg" },
                        new GridCollectionItemViewModel { Id = "6" , Title = "Apple watch collection", Price = 60, ImageUrl = "images/placeholders/270x295.svg" },
                        new GridCollectionItemViewModel { Id = "7" , Title = "Apple watch collection", Price = 70, ImageUrl = "images/placeholders/270x295.svg" },
                        new GridCollectionItemViewModel { Id = "8" , Title = "Apple watch collection", Price = 80, ImageUrl = "images/placeholders/270x295.svg" }
                    },
                    LoadMore = true,

                },

                UpToSell = new UpToSellViewModel
                {
                    Item_1 = new List<UpToSellItemsViewModel>
                    {
                        new UpToSellItemsViewModel { Id = "9", Title = "Apple watch collection", Price = 50, ImageUrl = "images/placeholders/369x310.svg" },

                    },

                    DiscoverContent = new DiscoverContentViewModel
                    {
                        TitleRed = "UP TO SELL",
                        Title = "50% OFF",
                        Ingress = "Get the Best Price",
                        Text = "Get the best daily offer et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren no sea taki"
                    },

                    Item_2 = new List<UpToSellItemsViewModel>
                    {
                        new UpToSellItemsViewModel { Id = "10", Title = "Apple watch collection", Price = 60, ImageUrl = "images/placeholders/369x310.svg" },

                    }
                },
                TopSelling = new TopSellingViewModel
                {
                    Title = "Top selling products in this week",

                    CollectionGrid = new List<GridCollectionItemViewModel>
                    {
                        new GridCollectionItemViewModel {Id = "11" , Title = "Apple watch collection", Price = 10, ImageUrl = "images/placeholders/270x295.svg"},
                        new GridCollectionItemViewModel {Id = "12" , Title = "Apple watch collection", Price = 10, ImageUrl = "images/placeholders/270x295.svg"},
                        new GridCollectionItemViewModel {Id = "13" , Title = "Apple watch collection", Price = 10, ImageUrl = "images/placeholders/270x295.svg"},
                        new GridCollectionItemViewModel {Id = "14" , Title = "Apple watch collection", Price = 10, ImageUrl = "images/placeholders/270x295.svg"},
                        new GridCollectionItemViewModel {Id = "15" , Title = "Apple watch collection", Price = 10, ImageUrl = "images/placeholders/270x295.svg"},
                        new GridCollectionItemViewModel {Id = "16" , Title = "Apple watch collection", Price = 10, ImageUrl = "images/placeholders/270x295.svg"},
                        new GridCollectionItemViewModel {Id = "17" , Title = "Apple watch collection", Price = 10, ImageUrl = "images/placeholders/270x295.svg"},

                    },
                    LoadMore = true,
                },
                Newsletter = new NewsletterViewModel { Placeholder = "Subscribe email here..." },

            };

            return View(viewModel);
        }
    }
}
