using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return "Hello World my first MVC web App";
            return View("Index");
        }

        
    }
}
