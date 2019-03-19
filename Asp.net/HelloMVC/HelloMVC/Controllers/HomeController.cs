using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var user = new User { UserName = "Fred" };
            return View(user);
        }

        public IActionResult IndexWithID(int id)
        {
            var user = new User { UserName = $"Fred #{id}" };
            // this wont work because there is not index with id
            // return View(user);
            // return View("Index");
            return View("Index", user);
        }

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
