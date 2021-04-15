using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Migrations;
using System.Data.Entity.Migrations;

namespace WebApplication1.DAL
{
    public class CarsInitializer : MigrateDatabaseToLatestVersion<CarsContext, WebApplication1.Migrations.Configuration>
    {
        public static void SeedCars(CarsContext context)
        {
            var categories = new List<Category>()
            {
                new Category
                {
                    CategoryID = 1,
                    Name = "Van",
                    Desc = "Samochod rodzinny"
                },
                new Category
                {
                    CategoryID = 2,
                    Name = "Sedan",
                    Desc = "Sportowy wyglad"
                },
                new Category
                {
                    CategoryID = 3,
                    Name = "Kombi",
                    Desc = "Dużo przestrzeni w bagażniku"
                },
                new Category
                {
                    CategoryID = 4,
                    Name = "Hatchback",
                    Desc = "Krótszy tył"
                }
            };

            foreach (var category in categories)
            {
                context.Categories.AddOrUpdate(category);
            }

            context.SaveChanges();

            var cars = new List<Car>()
            { 
                new Car
                {
                    CarID = 1,
                    Mark = "Ford",
                    Model = "Focus",
                    CategoryID = 3,
                    AddDate = DateTime.Now
                },
                new Car
                {
                    CarID = 2,
                    Mark = "Honda",
                    Model = "Civic",
                    CategoryID = 2,
                    AddDate = DateTime.Now
                },
                new Car
                {
                    Mark = "Nissan",
                    Model = "Skyline",
                    CategoryID = 2,
                    AddDate = DateTime.Now
                }
            };
            foreach (var car in cars)
            {
                context.Cars.AddOrUpdate(car);
            }

            context.SaveChanges();

        }
    }
}