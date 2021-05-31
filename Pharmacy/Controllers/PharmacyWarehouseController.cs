using Microsoft.AspNetCore.Mvc;
using Pharmacy.DataBaseConnection.Factory;
using Pharmacy.Models;

namespace Pharmacy.Controllers
{
    public class PharmacyWarehouse : Controller
    {
        [HttpGet]
        public IActionResult AllMedicine()
        {
            var allMedicine = Factory.GetMedicineInPharmacyWarehouse
                (DataBaseConnection.DatabaseConnection.GetMedicineInPharmacyWarehouse());
            ViewBag.AllMedicine = allMedicine;
            return View();
        }

        [HttpGet]
        public IActionResult Medicine(int medicineId)
        {
            var medicine = Factory.GetMedicineInPharmacyWarehouse
                (DataBaseConnection.DatabaseConnection.GetMedicineInPharmacyWarehouse(medicineId));
            ViewBag.Medicine = medicine;
            return View();
        }
        

        [HttpPost]
        public IActionResult CreateMedicine(Medicine medicine)
        {
            if (medicine != null)
            {
                DataBaseConnection.DatabaseConnection.InsertMedicine(medicine);
            }
            return Redirect("/Create");
        }
        
        [HttpPost]
        public IActionResult CreateDelivery(Delivery delivery)
        {
            if (delivery != null)
            {
                DataBaseConnection.DatabaseConnection.InsertDelivery(delivery);
            }
            return Redirect("/Create");
        }

        [HttpPost]
        public IActionResult CretePharmacyWarehouse (Models.PharmacyWarehouse pharmacyWarehouse)
        {
            if (pharmacyWarehouse != null)
            {
                DataBaseConnection.DatabaseConnection.InsertPharmacyWarehouse(pharmacyWarehouse);
            }

            return Redirect("/Create");
        }
        [HttpGet("Create")]
        public IActionResult Create()
        {
            var measureUnit = Factory.GetMeasureUnit(DataBaseConnection.DatabaseConnection.GetMeasureUnit());
            var producer = Factory.GetProducer(DataBaseConnection.DatabaseConnection.GetProducer());
            ViewBag.MeasureUnit = measureUnit;
            ViewBag.Producer = producer;
            var delivery = Factory.GetDelivery(DataBaseConnection.DatabaseConnection.GetDelivery());
            var medicine = Factory.GetMedicine(DataBaseConnection.DatabaseConnection.GetMedicine());
            ViewBag.Delivery = delivery;
            ViewBag.Medicine = medicine;
            return View();
        }
    }
}