using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyTravels.Data;
using MyTravels.Models;

namespace MyTravels.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Post()
        {
            ViewData["Message"] = "Here is all the posts we have.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Thank you for visiting our page!";

            return View();
        }

        [Authorize]
        public IActionResult CreatePost()
        {
            ViewData["Message"] = "Create your posts.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
