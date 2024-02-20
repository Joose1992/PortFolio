using Microsoft.AspNetCore.Mvc;

namespace PortFolio.Controllers
{
    public class MainPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
