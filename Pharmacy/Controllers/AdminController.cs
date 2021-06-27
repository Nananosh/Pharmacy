using Microsoft.AspNetCore.Mvc;
using Pharmacy.DataBaseConnection.Factory;

namespace Pharmacy.Controllers
{
    public class AdminController : Controller
    {
        // GET
        public IActionResult Report()
        {
            ViewBag.Report =
                Factory.GetMedicineInPharmacyWarehouse(DataBaseConnection.DatabaseConnection
                    .GetMedicineInPharmacyWarehouse());
            return View();
        }
    }
}