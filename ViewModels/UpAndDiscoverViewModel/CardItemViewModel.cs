﻿namespace WebApp.ViewModels.UpAndDiscoverViewModel;

public class CardItemViewModel
{
    public string Id { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
    public string Title { get; set; } = null!;
    public decimal Price { get; set; }
}
