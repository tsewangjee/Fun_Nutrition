using Microsoft.AspNetCore.Mvc;

namespace Fun_Nutrition.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
