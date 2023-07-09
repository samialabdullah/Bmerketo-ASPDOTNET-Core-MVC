﻿using Microsoft.AspNetCore.Mvc;
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
                        new UpToSellItemsViewModel { Id = "9", Price = 50, Title = "Apple watch collection", ImageUrl = "images/placeholders/369x310.svg" },

                    },
                    Item_2 = new List<UpToSellItemsViewModel>
                    {
                        new UpToSellItemsViewModel { Id = "10", Price = 60, Title = "Apple watch collection", ImageUrl = "images/placeholders/369x310.svg" },

                    },
                    DiscoverItem = new List<UpToSellItemsViewModel>
                    {
                        new UpToSellItemsViewModel {
                        TitleRed = "UP TO SELL",
                        Ingress = "Get the Best Price",
                        Title = "50% OFF",
                        Text = "Get the best daily offer et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren no sea taki" },
                    },
                },

            };

            return View(viewModel);
        }
    }
}
