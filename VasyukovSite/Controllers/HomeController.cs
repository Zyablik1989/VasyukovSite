using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VasyukovSite.Models;

namespace VasyukovSite.Controllers
{
    public class HomeController : Controller
    {
        [Route("Index")]
        //[Route("")]
        [Route("~/Home")]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]/{name?}")]
        public ViewResult Project(string name)
        {
            if (string.IsNullOrEmpty(name))
            name = "website";

            string model = name;
            return View("Project",model);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
