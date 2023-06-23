using App.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App.Web.Mvc.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
            var products = new List<Product>();

            products.Add(new Product() { Title = "Buzdolabı", StarCount = 2, OldPrice = 30.000M, Price = 20.000M, ImageUrl = "/images/Eticaret/buzdolabi.png", isSale = true });
            products.Add(new Product() { Title = "Camasır Makinesi", StarCount = 5, OldPrice = 20.000M, Price = 10.000M, ImageUrl = "/images/Eticaret/camasir.png", isSale = false });
            products.Add(new Product() { Title = "Bulaşık Makinesi", StarCount = 3, OldPrice = 0, Price = 25.000M, ImageUrl = "/images/Eticaret/bulasik.png", isSale = true });
            products.Add(new Product() { Title = "Kurutma Makinesi", StarCount = 2, OldPrice = 0, Price = 17.000M, ImageUrl = "/images/Eticaret/kurutma.png", isSale = false });
            products.Add(new Product() { Title = "Ütü", StarCount = 0, OldPrice = 3.000M, Price = 1.000M, ImageUrl = "/images/Eticaret/utu.png", isSale = true });
            products.Add(new Product() { Title = "Tost Makinesi", StarCount = 2, OldPrice = 0, Price = 10.000M, ImageUrl = "/images/Eticaret/tost.png", isSale = false });
            products.Add(new Product() { Title = "Kahve Makinesi", StarCount = 5, OldPrice = 10.000M, Price = 7.000M, ImageUrl = "/images/Eticaret/Kahve.png", isSale = true });
            products.Add(new Product() { Title = "Blender", StarCount = 4, OldPrice = 0, Price = 4.000M, ImageUrl = "/images/Eticaret/blender.png", isSale = false });

            return View(products);
            
		}
	}
}