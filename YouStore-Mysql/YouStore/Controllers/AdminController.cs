using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Logic;
using YouStore.ViewsModels;
using System.Threading;
using Data;
using Microsoft.AspNetCore.Authorization;

namespace YouStore.Controllers
{
    
    
    public class AdminController : Controller
    {
        AdminLogic Adminlogic = new AdminLogic();

        
        public IActionResult Index()
        {
            return View();
        }

        
        public ActionResult AdminHome()
        {
            return View();
        }
   

        public ActionResult ProductsList()
        {
            
            List<Product> resultDto = Adminlogic.GetAllProducts();
           
            return View(Adminlogic.GetAllProducts());
        }
       



        public ActionResult Addproduct(AddProduct model)
        {
            return View(model);
        }

        [HttpPost]
        public ActionResult AddProduct(AddProduct model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Product product = new Product();
   
            Adminlogic.AddProduct(model.ProductName,model.ProductDescription,model.ProductPrijs,model.ProductCode, model.QuantityInStock, model.Productimagelink);
            

            return RedirectToAction("ProductsList", "Admin");
        }

        public ActionResult ShowOdersCount()
        {
         
          

            return View(Adminlogic.GetCountOfOrders());
        }
       

        public ActionResult OrdersList()
        {
          
            List<Order> Orders = Adminlogic.GetAllOrders();

            return View(Orders);
        }

        public ActionResult DeletProduct(int? ProductId)
        {

            Adminlogic.DeletProduct(Convert.ToInt32(ProductId));

            return RedirectToAction("ProductsList", "Admin");
        }

        public IActionResult EditProductInformatie(int id)
        {
          

            List<Product> Products = Adminlogic.GetAllProducts();


            Product Product = new Product();

            foreach (Product P in Products)
            {
                if (P.ProductId == id)
                {
                    Product = P;
                    break;
                }
            }
            EditProduct model = new EditProduct();


            model.ProductName = Product.ProductName;
            model.ProductDescription = Product.ProductDescription;
            model.ProductPrijs = Product.ProductPrijs;
            model.ProductCode = Product.ProductCode;
            model.QuantityInStock = Product.QuantityInStock;
            model.Productimagelink = Product.Productimagelink;


            
            return View(model);
        }

        [HttpPost]
        public IActionResult EditProductInformatie(int id, EditProduct product)
        {



            Adminlogic.EditProduct(id, product.ProductName, product.ProductDescription, product.ProductPrijs, product.ProductCode, product.QuantityInStock, product.Productimagelink);

            if (Adminlogic.EditProduct(id, product.ProductName, product.ProductDescription, product.ProductPrijs, product.ProductCode, product.QuantityInStock, product.Productimagelink) == false)
            {
                return RedirectToAction("Error", "Home");
            }


            return RedirectToAction("ProductsList", "Admin");
        }

    }
}