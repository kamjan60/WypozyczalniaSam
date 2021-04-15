using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Category
    {
        public ICollection<Car> Cars { get; set; }

        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

    }
}