using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;

namespace WebApplication1.Controllers
{
    public class CarsController : Controller
    {
        //Dodanie obiektu bazy danych
        CarsContext db = new CarsContext();
        // GET: Cars
        public ActionResult Index()
        {
            return View();
        }
        //Dodanie akcji zczytywania pojazdów do listy związanej z kategorią
        public ActionResult List(string categoryName) {
            var category = db.Categories.Include("Cars").Where(c => c.Name.ToUpper() == categoryName.ToUpper()).Single();
            var cars = category.Cars.ToList();
            return View(cars);
        }
    }
}