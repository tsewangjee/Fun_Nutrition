﻿using Microsoft.AspNetCore.Mvc;

namespace Fun_Nutrition.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Display_Percentage()
        {
            
            double num = 0.02;
            ViewBag.Percentage = num.ToString();
            return View();
        }

        public void result()
        {
            int wer = 0;
            int her = 0;
            string trim = "";

            //methods to be added
        }
    }
}
