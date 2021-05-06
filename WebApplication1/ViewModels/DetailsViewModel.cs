using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.VievModels
{
    //tworzymy nowy model z elementami dynamicznymi
    public class DetailsViewModel
    {
        public Category Category { get; set; }
        public IEnumerable<Car> CarsFromCategory { get; set; }
        public IEnumerable<Car> Top3NewestCars { get; set; }
    }
}