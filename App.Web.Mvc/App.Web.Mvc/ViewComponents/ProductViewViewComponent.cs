namespace App.Web.Mvc.ViewComponents;
using App.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

public class ProductViewViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(string title, int starCount, decimal oldPrice, decimal price, string imageUrl, bool isScale)
    {
        var product = new Product()
        {
            Title = title,
            StarCount = starCount,
            OldPrice = oldPrice,
            Price = price,
            ImageUrl = imageUrl,
            isSale = isScale
        };
        return View();
    }
}

