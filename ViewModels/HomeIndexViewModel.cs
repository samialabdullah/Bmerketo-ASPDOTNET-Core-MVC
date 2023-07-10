﻿namespace WebApp.ViewModels
{
    public class HomeIndexViewModel
    {
        public string Title { get; set; } = "Home";
        public GridCollectionViewModel BestCollection { get; set; } = null!;
        public GridCollectionViewModel SummerCollection { get; set; } = null!;
        public UpToSellViewModel UpToSell { get; set; } = null!;
        public TopSellingViewModel TopSelling { get; set; } = null!;
        public NewsletterViewModel Newsletter { get; set; } = null!;


    }
}
