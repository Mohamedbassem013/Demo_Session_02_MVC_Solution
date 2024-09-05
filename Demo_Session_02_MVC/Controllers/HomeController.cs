using Microsoft.AspNetCore.Mvc;

namespace Demo_Session_02_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); //HTML Pages
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContcatUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
