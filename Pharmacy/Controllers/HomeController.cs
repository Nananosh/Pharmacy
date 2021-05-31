using Microsoft.AspNetCore.Mvc;
using Pharmacy.DataBaseConnection.Factory;

namespace Pharmacy.Controllers
{
    public class Home : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var allMedicine = Factory.GetMedicineInPharmacyWarehouse
                (DataBaseConnection.DatabaseConnection.GetMedicineInPharmacyWarehouse());
            allMedicine.Reverse();
            ViewBag.Count = 1;
            ViewBag.AllMedicine = allMedicine;
            return View();
        }
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }
    }
}