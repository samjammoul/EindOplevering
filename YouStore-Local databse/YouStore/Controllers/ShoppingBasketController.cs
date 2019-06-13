using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace YouStore.Controllers
{
    public class ShoppingBasketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult AddProductsToShoppingBasket(int? ProductId)
        {
            int? ClientId = HttpContext.Session.GetInt32("ClientId");
            AdminLogic admin = new AdminLogic();
            List<Product> allproducts = admin.GetAllProducts();
            ShoppingBasketLogic Basket = new ShoppingBasketLogic();
            ClientLogic clientlogic = new ClientLogic();
            foreach (Product p in allproducts)
            {
                if (ProductId == p.ProductId)
                {
                    clientlogic.AddProductToShoppingBasket(Convert.ToInt32(ClientId), Convert.ToInt32(ProductId));
                    
                }
            }
          
            return RedirectToAction("HomeClient", "Home");
        }
        public ActionResult ProductsList()
        {
            Product product = new Product();

            ShoppingBasketLogic Basket = new ShoppingBasketLogic();

            return View(Basket.AddProductsToShoppingBasket(product));
        }
        public IActionResult ShowProducts()
        {
            ShoppingBasketLogic Basket = new ShoppingBasketLogic();

            List<Product> products = new List<Product>();

            
            return RedirectToAction("ShoppingBasket", "SBProductsList");
        }
        public ActionResult ShoppingBasketItems()
        {
            int? ClientId = HttpContext.Session.GetInt32("ClientId");
            ClientLogic ClientLogic = new ClientLogic();

            ViewData["List"] = ClientLogic.GetAllProductsForUser(Convert.ToInt32(ClientId));
            



            return View(ClientLogic.GetAllProductsForUser(Convert.ToInt32(ClientId)));
        }
        public ActionResult DeleteProduct(int? id)
        {
            int? ClientId = HttpContext.Session.GetInt32("ClientId");
            ClientLogic clientlogic = new ClientLogic();
           
            clientlogic.DeletProduct(Convert.ToInt32(id),Convert.ToInt32(ClientId));
            return RedirectToAction("ShoppingBasketItems");
        }
    }
}