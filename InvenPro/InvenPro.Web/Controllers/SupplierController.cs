using InvenPro.Web.Data;
using InvenPro.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace InvenPro.Web.Controllers
{
    public class SupplierController : Controller
    {
        readonly InvenProDbContext _db;

        public SupplierController(InvenProDbContext db)
        {
            _db = db;
            
        }
        public ActionResult Index()
        {
            var vm = new SuppliersViewModel();
            var allSuppliers = _db.Supplier.ToList();
            var ActiveSupplier = _db.Supplier.Where(p => p.IsActive) .ToList();
            //ViewBag.SupplierInformation = info2;

            vm.ActiveSuppliers = ActiveSupplier;
            vm.AllSuppliers = allSuppliers;

            return View(vm);

        }
    }
}