using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.ViewModels
{
    public class ItemRemoveViewModel
    {
        public int itemId { get; set; }
        public int itemQuantity { get; set; }
        public decimal cartValue { get; set; }

        public int cartQuantity { get; set; }
    }
}