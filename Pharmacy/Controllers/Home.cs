using Microsoft.AspNetCore.Mvc;

namespace Pharmacy.Controllers
{
    public class Home : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}