using WebApp.Models;

namespace WebApp.Services;
public class ShowcaseService
{
    private readonly List<ShowcaseModel> _showcase = new()
    {
        new ShowcaseModel()
        {
            Ingress="WELCOME TO BMERKETO SHOP",
            Title="Exclusive Chair gold Collection.",
            ImageUrl="images/placeholders/625x647.svg",
            Button =new LinkButtonModel
            {
                Content = "SHOP NOW",
                Url = "/products"
            }
        },


    };

    public ShowcaseModel GetLatest()
    {
        return _showcase.LastOrDefault()!;
    }
}