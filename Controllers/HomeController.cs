using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels.HomeViewModel;
using WebApp.ViewModels.UpAndDiscoverViewModel;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Home";

            var viewModel = new HomeIndexViewModel()
            {
                BestCollection = new GridCollectionViewModel
                {
                    Title = "Best collection",
                    Categories = new List<string> { "Bag", "Dress", "Decoration", "Essentials", "Interior", "Laptop", "Mobile", "Beaty", },
                    Griditems = new List<GridCollectionItemViewModel>()
                    {
                        new GridCollectionItemViewModel {},
                    },
                    LoadMore = true,
                },

                UpToSell = new UpToSellViewModel
                {
                    CardItem_one = new List<CardItemViewModel>
                    {
                        new CardItemViewModel { Id = "16", Price = 80, Title = "Apple new watch", ImageUrl = "images/placeholders/369x310.svg" },

                    },

                    Discover = new DiscoverItemViewModel()
                    {
                        TitleRed = "UP TO SELL",
                        Ingress = "Get the Best Price",
                        Title = "50% OFF",
                        Text = "Get the best daily offer et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren no sea taki"
                    },

                    CardItem_two = new List<CardItemViewModel>
                    {
                        new CardItemViewModel { Id = "17", Price = 70, Title = "Apple headset collection", ImageUrl = "images/placeholders/369x310.svg" },

                    },

                },
                TopSelling = new TopSellingViewModel
                {
                    Title = "Top selling products in this week",

                    CollectionGrid = new List<GridCollectionItemViewModel>
                    {
                        new GridCollectionItemViewModel {},

                    },
                    LoadMore = true,
                },
                NewsLetter = new NewsLetterViewModel { Placeholder = "subscribe mail here..." },
            };

            return View(viewModel);
        }

    }
}
