using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Car
    {
        public int CarID { get; set; }

        [Required(ErrorMessage = "Wprowadź markę samochodu")]
        public string Mark { get; set; }

        [Required(ErrorMessage = "Wprowadź model samochodu")]
        public string Model { get; set; }

        [StringLength(100)]
        public string Desc { get; set; }
        public decimal Price { get; set; }
        public DateTime AddDate { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }


    }
}