using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using YouStore.ViewsModels;
using YouStorePro.ViewsModels;

namespace YouStore.Controllers
{
    public class ClientController : Controller
    {
        ClientLogic ClientLogic = new ClientLogic();

        Client client = new Client();

        public IActionResult Index()
        {
            return View();
        }

  

        public ActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
         

            foreach (var i in ClientLogic.GetAllUsers())
            {
                
                if (i.Email == model.Email && i.Password == model.Password)
                {
                    if (i.IsAdmin)
                    { return RedirectToAction("AdminHome", "Admin"); }
                    else
                    {
                        HttpContext.Session.SetString("Firstname", i.UserFirstName);
                        HttpContext.Session.SetString("Email", i.Email);
                        HttpContext.Session.SetInt32("ClientId", i.Id);
                       
                        
                        
                        return RedirectToAction("HomeClient", "Home");
                    }
                    
                }
                
                
            }
            return View(model);
        }
        public ActionResult ProductenKopen()
        {
            int? ClientId = HttpContext.Session.GetInt32("ClientId");
            string UserEmail = HttpContext.Session.GetString("Email");
            string UserFirstName = HttpContext.Session.GetString("Firstname");
  
            ShoppingBasketLogic  basket = new ShoppingBasketLogic();
            foreach (Product i in ClientLogic.GetAllProductsForUser(Convert.ToInt32(ClientId)))
            {
                ClientLogic.SetOrder(Convert.ToInt32(ClientId), i.ProductId, UserEmail, UserFirstName);
            }

            return RedirectToAction("HomeClient", "Home");
        }
        public ActionResult OrdersList()
        {
            int? ClientId = HttpContext.Session.GetInt32("ClientId");
            
            

         



            return View(ClientLogic.GetAllOrders(Convert.ToInt32(ClientId)));
        }


        public ActionResult ClientProfile()
        {
            int? ClientId = HttpContext.Session.GetInt32("ClientId");
            
            List<Client> Clients = ClientLogic.GetAllUsers();
            
            
            foreach (Client C in Clients)
            {
                if (C.Id == Convert.ToInt32(ClientId))
                {
                    client = C;
                    break;
                }
            }


            return View(client);
        }
        public IActionResult EditClientProfile()
        {

            int? ClientId = HttpContext.Session.GetInt32("ClientId");
            
            List<Client> Clients = ClientLogic.GetAllUsers();
            

            foreach (Client C in Clients)
            {
                if (C.Id == Convert.ToInt32(ClientId))
                {
                    client = C;
                    break;
                }
            }


            EditPersonelInformation model = new EditPersonelInformation();
            model.UserFirstName = client.UserFirstName;
            model.UserLastName = client.UserLastName;
            model.Email = client.Email;
            model.City = client.City;
            model.State = client.State;
            model.PostalCode = client.PostalCode;
            model.Phone = client.Phone;
            model.Street = client.Street;
            model.Country = client.Country;
            return View(model);
        }

        [HttpPost]
        public IActionResult EditClientProfile(EditPersonelInformation model)
        {
            int? clientId = HttpContext.Session.GetInt32("ClientId");

            int ClientId = Convert.ToInt32(clientId);



            ClientLogic.EditClientProfile(ClientId,model.UserFirstName,model.Email, model.UserLastName,model.City,model.Street,model.State,model.Phone,model.PostalCode,model.Country);




            return RedirectToAction("ClientProfile");
        }
        public ActionResult DeletAccount()
        {
            int? ClientId = HttpContext.Session.GetInt32("ClientId");



            ClientLogic.DeletAccount(Convert.ToInt32(ClientId));


            return RedirectToAction("Login");
        }



    }
}