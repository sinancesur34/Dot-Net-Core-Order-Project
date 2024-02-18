using Microsoft.AspNetCore.Mvc;

namespace Coreilk.Controllers
{
    public class Order : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
