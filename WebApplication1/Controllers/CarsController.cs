using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.VievModels;

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
            var nowosci = db.Cars.OrderByDescending(c => c.AddDate).Take(3);
            //zapytanie zwracajace nam 3 najnowsze samochody
            DetailsViewModel model = new DetailsViewModel() {
                CarsFromCategory = cars,
                Top3NewestCars = nowosci,
                Category = category
            };
            return View(model);
        }

        //tworzymy metode zwracającą widok cząstkowy
        //mozna go stworzyc PPM na nazwie metody -> Add View (zaznaczayc checkbox partial view)
        //trzeba pamietac o wywolaniu akcji w headerze Layout
        public ActionResult KategorieMenu()
        {
            var kategorie = db.Categories.ToList();
            return PartialView("_KategorieMenu", kategorie);
        }
        public ActionResult Details(int id)
        {
            var car = db.Cars.Find(id);
            return View(car);
        }
        public ActionResult CarsFromCategory(string categoryName)
        {
            var category = db.Categories.Include("Cars").Where(c => c.Name.ToUpper() == categoryName.ToUpper()).Single();
            return PartialView("_CarsFromCategory", category.Cars.ToList());
        }
        //partial widok dodajemy z _przedNazwą - ogólnie przyjęta zasada
    }
}