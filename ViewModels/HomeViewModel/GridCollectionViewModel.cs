﻿namespace WebApp.ViewModels.HomeViewModel
{
    public class GridCollectionViewModel
    {
        public string Title { get; set; } = "";
        public IEnumerable<string> Categories { get; set; } = null!;
        public IEnumerable<GridCollectionItemViewModel> Griditems { get; set; } = null!;
        public bool LoadMore { get; set; } = false;
    }
}
