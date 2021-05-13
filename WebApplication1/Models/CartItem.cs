using WebApplication1.Models;

namespace WebApplication1.Infrastructure
{
    public class CartItem
    {
        public Car Car { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
    }
}