using Microsoft.AspNetCore.Mvc;
using P015Etut07.Models;
using System.Diagnostics;

namespace P015Etut07.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var posts = new List<PostViewModel>();
            posts.Add(new PostViewModel() { Id = 1, Title = "Post 1", Description = "Post açıklama 1" });
            posts.Add(new PostViewModel() { Id = 2, Title = "Post 2", Description = "Post açıklama 2" });
            posts.Add(new PostViewModel() { Id = 2, Title = "Post 3", Description = "Post açıklama 3" });
            posts.Add(new PostViewModel() { Id = 2, Title = "Post 4", Description = "Post açıklama 4" });
            return View(posts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}