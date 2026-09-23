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
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult GetTrail()
        {
            // create a sample trail object (later, we will pull this from db)
            Trail trail = new Trail();
            trail.Id = 1;
            trail.Title = "Pot Lake Trail";
            trail.Description = "A scenic trail with beautiful views of the lake.";
            trail.Length = 5.2;
            trail.ElevationGain = 300;
            trail.Location = "Pot Lake Loop, Otter Lake, NS B3Z 1A9";

            return View(trail); // pass trail object into view to display the trail details
        }

        public IActionResult GetAllTrails()
        {
            List<Trail> trails = new List<Trail>();

            Trail trail = new Trail();
            trail.Id = 1;
            trail.Title = "Pot Lake Trail";
            trail.Description = "A scenic trail with beautiful views of the lake.";
            trail.Length = 5.2;
            trail.ElevationGain = 300;
            trail.Location = "Pot Lake Loop, Otter Lake, NS B3Z 1A9";

            Trail trail2 = new Trail();
            trail2.Id = 2;
            trail2.Title = "Johnson Lake Trail";
            trail2.Description = "A scenic trail with beautiful views of the lake.";
            trail2.Length = 5.2;
            trail2.ElevationGain = 300;
            trail2.Location = "Pot Lake Loop, Otter Lake, NS B3Z 1A9";

            Trail trail3 = new Trail();
            trail3.Id = 3;
            trail3.Title = "Point Pleasant Park";
            trail3.Description = "A scenic trail with beautiful views of the lake.";
            trail3.Length = 5.2;
            trail3.ElevationGain = 300;
            trail3.Location = "Pot Lake Loop, Otter Lake, NS B3Z 1A9";

            trails.Add(trail);
            trails.Add(trail2);
            trails.Add(trail3);

            return View(trails);
        }


        /*
         *  Add an Action Method to display a list of trails.
            Create a sample list including 3 trails (objects).
            Pass the list object into a View.
            Display the records in the View in a table format.
         */







        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
