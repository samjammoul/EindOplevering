using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace YouStore.Controllers
{
    public class WebCollectionController : Controller
    {
        public ActionResult ProductPage(int? ProductId)
        {
            AdminLogic adminlogic = new AdminLogic();
            List<Product> Products = adminlogic.GetAllProducts();
            Product product = new Product();

            foreach (Product p in Products)
            {
                if (p.ProductId == Convert.ToInt32(ProductId))
                {
                    product = p;
                    break;
                }
            }
           

            return View(product);
        }
    }
}