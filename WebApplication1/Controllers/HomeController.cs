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

            //Zebranie kategorii do listy i wrzucenie ich widoku
            var categories = db.Categories.ToList();
            
            return View(categories);
        }

        //Dodanie metody zwracającej widok strony statycznej
        public ActionResult StronyStatyczne(string nazwa)
        {
            return View(nazwa);
        }
    }
}