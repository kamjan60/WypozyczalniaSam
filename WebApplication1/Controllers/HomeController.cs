using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        CarsContext db = new CarsContext();

        // GET: Home
        public ActionResult Index()
        {
           Category category = new Category()
            {
                CategoryID = 1,
                Name="Van",
                Desc = "Samochod rodzinny"
            };
            db.Categories.AddOrUpdate(category);
            db.SaveChanges();

            return View();
        }
    }
}