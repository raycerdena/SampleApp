using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //private ApplicationDbContext _context;
        //public HomeController()
        //{
        //    _context = new ApplicationDbContext();
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    _context.Dispose();
        //}

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }



        public ActionResult Register()
        {



            return View();
        }

    }
}
