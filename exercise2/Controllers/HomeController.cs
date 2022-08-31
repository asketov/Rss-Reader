using exercise2.ApplicationServices;
using exercise2.DomainServices;
using exercise2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace exercise2.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeService _homeService;
        public HomeController(HomeService homeService)
        {
            _homeService = homeService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Posts = _homeService.GetAllPostsFromRss()
            };
            return View(homeVM);
        }

    }
}
