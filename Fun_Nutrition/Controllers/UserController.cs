using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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

        public void result(int x, int y)
        {
            int wer = 0;
            int her = 0;
            string trim = "";
            bool res = check(trim);

            if (res)
                her = 1;
            else
                wer = 1;
            x = wer;
            y = her;
        }

        public bool check(string trim_str)
        {
            if (trim_str == "")
                return false;
            else
                return true;
        }

        public Enumerable<string> lstStr(string trim_str)
        {
            List<string> vs = new List<string>();
            string str = "test";
            vs.Add(str);
            return vs.AsEnumerable();
        }
    }
}
