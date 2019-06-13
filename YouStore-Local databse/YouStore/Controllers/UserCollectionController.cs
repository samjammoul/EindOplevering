using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Logic;
using Microsoft.AspNetCore.Http;

namespace YouStore.Controllers
{
    public class UserCollectionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult SingUp(User model)
        {
            return View(model);
        }
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult singUp(User model)
        {
          
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            ClientLogic clientlogic = new ClientLogic();
            foreach ( User user in clientlogic.GetAllUsers() )
            {
                if (model.Email == user.Email)
                {
                    ViewBag.message = "Dit Email heeft al een account !";
                    return View(model);
                }
            }

            UserCollectionlogic userCollectionLogic = new UserCollectionlogic(model);
            userCollectionLogic.SignUp(model);
            userCollectionLogic.SendWelcomMail(model.Email, model.UserFirstName);

            return RedirectToAction("Index", "Home");
        }
        

    }
}