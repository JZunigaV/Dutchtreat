using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {                        
            throw new System.Exception("Valio verch");
            return View();
        }
    }
}