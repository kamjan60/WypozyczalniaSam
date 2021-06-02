using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Infrastructure;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class CartController : Controller
    {
        CartManager cartManager;
        CarsContext db;
        ISessionManager sessionManager;

        public CartController()
        {
            db = new CarsContext();
            sessionManager = new SessionManager();
            cartManager = new CartManager(db,sessionManager);
        }

        public ActionResult Index()
        {
            var cart = cartManager.GetItems();
            var totalValue = cartManager.GetCartValue();
            CartViewModel cvm = new CartViewModel()
            {
                CartItems = cart,
                TotalPrice = totalValue
            };
            return View(cvm);
        }

        public ActionResult AddToCart(int id)
        {
            cartManager.AddToCart(id);
            return RedirectToAction("Index");
        }

        public int GetCartQuantity()
        {
            return cartManager.GetCartQuantity();
        }

        public ActionResult RemoveFromCart(int id)
        {
            ItemRemoveViewModel irvm = new ItemRemoveViewModel()
            {
                itemQuantity = cartManager.RemoveFromCart(id),
                cartValue = cartManager.GetCartValue(),
                itemId = id,
                cartQuantity = cartManager.GetCartQuantity()
            };
            return Json(irvm);
        }
    }
}