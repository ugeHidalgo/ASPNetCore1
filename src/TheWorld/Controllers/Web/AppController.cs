
using Microsoft.AspNetCore.Mvc;

namespace TheWorld.Controllers.Web
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();  //renderiza la vista y la devuelve.
        } 
    }
}
