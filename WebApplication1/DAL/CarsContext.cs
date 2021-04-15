using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class CarsContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }

        public CarsContext(): base("CarsContext")
        {

        }

        static CarsContext()
        {
            Database.SetInitializer<CarsContext>(new CarsInitializer());
        }
    }
}