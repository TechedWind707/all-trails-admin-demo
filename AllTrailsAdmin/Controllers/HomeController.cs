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
        }

        // Action Method /Index
        public IActionResult Index()
        {
            return View();
        }

        // Action Method /Privacy
        public ViewResult Privacy()
        {
            return View();
        }

        // Action Method /HelloWorld
        public IActionResult HelloWorld()
        {
            //return View();
            return  NotFound();
        }

        // Action method
        public JsonResult PersonJson()
        {
            Person person = new Person();
            person.Id = 1;
            person.Name = "Han Solo";
            person.Email = "hansolo@rebels.ca";

            return Json(person);
        }

        public ContentResult PlainText()
        {
            return Content("This is plain text content.");
        }


        // Create a new action method called PersonJson
        // Create a Person class with id, name, and email
        // Initialize a sample Person and return it as Json in the Action Method




        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
