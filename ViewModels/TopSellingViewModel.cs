namespace WebApp.ViewModels
{
    public class TopSellingViewModel
    {
        public string Title { get; set; } = "";
        public IEnumerable<GridCollectionItemViewModel> CollectionGrid { get; set; } = null!;
        public bool LoadMore { get; set; } = false;
    }
}
