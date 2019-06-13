using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Logic;
using Models;
using YouStore.ViewsModels;

namespace YouStore.Controllers
{
    public class YoutuberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult YoutuberList()
        {
            YoutuberLogic yotuber = new YoutuberLogic();
            

            //products.Add(new Product{ProductName="pp"});



            return View(yotuber.GetAllYouTubers());
        }
        public IActionResult ShowYoutubers()
        {
            return RedirectToAction("YoutuberList", "Youtuber");
        }
        public ActionResult ShowYoutuberProducts(int? YoutuberId)
        {
            
            YoutuberLogic youtuberlogic = new YoutuberLogic();

         

            return View(youtuberlogic.GetYoutubersProducts(Convert.ToInt32(YoutuberId)));
        }
        public ActionResult Youtubers()
        {
            YoutuberLogic logic = new YoutuberLogic();
            List<Youtuber> resultDto = logic.GetAllYouTubers();

            return View(logic.GetAllYouTubers());
        }

        public ActionResult addYoutuber(AddYouTuber model)
        {
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddYoutuber(AddYouTuber model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
           

            YoutuberLogic YoutuberLogic = new YoutuberLogic();

            YoutuberLogic.AddYoutuber(model.YoutuberName, model.YoutuberImage);


            return RedirectToAction("Youtubers", "Youtuber");
        }

        public ActionResult DeletYoutuber(int? YoutuberId)
        {
            YoutuberLogic Youtuberlogic = new YoutuberLogic();

            Youtuberlogic.DeletYoutuber(Convert.ToInt32(YoutuberId));

            return RedirectToAction("Youtubers", "Youtuber");
        }

        

        public IActionResult EditYoutuberInformatie(int id)
        {
            YoutuberLogic Youtuberlogic = new YoutuberLogic();

            List<Youtuber> Youtubers = Youtuberlogic.GetAllYouTubers();


            Youtuber Youtuber = new Youtuber();

            foreach (Youtuber youtuber in Youtubers)
            {
                if (youtuber.YoutuberId == id)
                {
                    Youtuber = youtuber;
                    break;
                }
            }


            YouTuberEdit model = new YouTuberEdit();

            model.YoutuberName = Youtuber.YoutuberName;

            model.YoutuberImage = Youtuber.YoutuberImage;

            return View(model);
        }

        [HttpPost]
        public IActionResult EditYoutuberInformatie(int id, YouTuberEdit youtuber)
        {
            
            YoutuberLogic YoutuberLogic = new YoutuberLogic();


            YoutuberLogic.YoutuberEdit(id, youtuber.YoutuberName,youtuber.YoutuberImage);


            return RedirectToAction("Youtubers", "Youtuber");
        }

    }

}