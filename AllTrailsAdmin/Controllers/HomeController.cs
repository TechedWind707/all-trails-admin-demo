using AllTrailsAdmin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AllTrailsAdmin.Controllers
{
    public class HomeController : Controller
    {
        // Constructor
        public HomeController()
        {
            Console.WriteLine("Constructor is called!");
        }

        // Action Method /Index
        public IActionResult Index()
        {
            Console.WriteLine("Hello from the Home/Index.");

            return View();
        }

        // Action Method /Privacy
        public IActionResult Privacy()
        {
            Console.WriteLine("Hello from the Home/Privacy.");

            return View();
        }





        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
