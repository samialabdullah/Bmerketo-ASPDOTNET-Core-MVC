namespace WebApp.ViewModels;

public class UpToSellViewModel
{
    public IEnumerable<UpToSellItemViewModel> CardItem_one { get; set; } = null!;
    public IEnumerable<UpToSellItemViewModel> CardItem_two { get; set; } = null!;
    public UpToSellDiscoverViewModel Discover { get; set; } = null!;
}
