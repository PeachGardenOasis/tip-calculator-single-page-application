using lab2_singlewebpageapp.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab2_singlewebpageapp.Controllers
{
    public class HomeController : Controller // Traffic Cop 
        // httpsclone PUSH
    {
        [HttpGet] // http get
        public IActionResult Index()
        {
            ViewBag.Fifteen = 0; // envelope that can store attributes 
            ViewBag.Twenty = 0;
            ViewBag.TwentyFive = 0;
            return View();
        }
        [HttpPost] // http post

        public IActionResult Index(TipCalculator tip) // forwarding user to another view
        {
            if(ModelState.IsValid)
            {
                ViewBag.Fifteen = tip.CalculateTip(0.15);
                ViewBag.Twenty = tip.CalculateTip(0.20);
                ViewBag.TwentyFive = tip.CalculateTip(0.25);


            }
            else
            {
                ViewBag.Fifteen = 0; // envelope that can store attributes 
                ViewBag.Twenty = 0;
                ViewBag.TwentyFive = 0;
            }
            return View(tip);
        }

    }
}
