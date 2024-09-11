using Microsoft.AspNetCore.Mvc;

namespace C42_G04_MVC01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // HTML Page
        }



        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}
