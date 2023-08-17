namespace WebApp.ViewModels.UpAndDiscoverViewModel;

public class UpToSellViewModel
{
    public IEnumerable<CardItemViewModel> CardItem_one { get; set; } = null!;
    public IEnumerable<CardItemViewModel> CardItem_two { get; set; } = null!;
    public DiscoverItemViewModel Discover { get; set; } = null!;
}
