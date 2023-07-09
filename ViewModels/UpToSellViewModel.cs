namespace WebApp.ViewModels
{
    public class UpToSellViewModel
    {
        public IEnumerable<UpToSellItemsViewModel> Item_1 { get; set; } = null!;
        public IEnumerable<UpToSellItemsViewModel> Item_2 { get; set; } = null!;
        public IEnumerable<UpToSellItemsViewModel> DiscoverItem { get; set; } = null!;
    }
}
