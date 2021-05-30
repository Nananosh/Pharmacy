using Microsoft.AspNetCore.Mvc;

namespace Pharmacy.Controllers
{
    public class PharmacyWarehouse : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}