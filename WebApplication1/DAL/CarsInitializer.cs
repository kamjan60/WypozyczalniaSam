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
                    Mark = "Ford",
                    Model = "Focus",
                    CarRegistration = "CB000001",
                    CategoryID = 3,
                    AddDate = DateTime.Now
                },
                new Car
                {
                    Mark = "Honda",
                    Model = "Civic",
                    CarRegistration = "CB000002",
                    CategoryID = 2,
                    AddDate = DateTime.Now
                },
                new Car
                {
                    Mark = "Nissan",
                    Model = "Skyline",
                    CarRegistration = "CB000003",
                    CategoryID = 2,
                    AddDate = DateTime.Now
                }
            };
            foreach (var car in cars)
            {
                //Zmiana przeglądania bazy, nie po CarID tylko przez CarRegistration.
                //add-Migration 'nazwa'     dodanie migracji
                //coś nie działą i chce wrócić - update-Database-TargetMigration:podajemyNazweMigracji
                //update-DataBase odświeżenie bazy danych
                context.Cars.AddOrUpdate(c=>c.CarRegistration,car);
            }

            context.SaveChanges();

        }
    }
}