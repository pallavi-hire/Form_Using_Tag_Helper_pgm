using Form_Using_Tah_Helper_pgm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Form_Using_Tah_Helper_pgm.Controllers
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
            return View();
        }

        [HttpPost]
        public IActionResult Index(Employee e)
        {
            return View();
        }
        //public string Index(Employee e)
        //{ 
        //    if (ModelState.IsValid)
        //    {
        //        return "Name =  " + e.Name + " Gender =   " + e.Gender+ "Age =   " +e.Age+  "desg=  "  +e.Desg+   "salary=   " +e.salary+ "married =   " +e.Married;
        //    }
        //    else
        //    {
        //        return "validation failed";
        //    }
        //}

        //public string Details(int id, string name)
        //{
        //    return "id =  " + id + " name =   " + name;
        //}



        public IActionResult Privacy()
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
