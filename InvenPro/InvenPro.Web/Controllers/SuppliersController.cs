
using InvenPro.Domain;
using InvenPro.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InvenPro.Web.Controllers
{
    public class SuppliersController : Controller
    {
        readonly InvenProDbContext _db;

        public SuppliersController(InvenProDbContext db)
        {
            _db = db;
            
        }
        public ActionResult Index()
        {
            var vm = new SuppliersViewModel();
            var allSuppliers = _db.Suppliers.ToList();
            var ActiveSuppliers = _db.Suppliers.Where(p => p.IsActive) .ToList();
            //ViewBag.SupplierInformation = info2;

            vm.ActiveSuppliers = ActiveSuppliers;
            vm.AllSuppliers = allSuppliers;

            return View(vm);

        }

		// GET: Suppliers/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Suppliers/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(Suppliers supplier)
		{
			if (ModelState.IsValid)
			{
				_db.Add(supplier);
				await _db.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(supplier);
		}

		// GET: Suppliers/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var supplier = await _db.Suppliers
				.FirstOrDefaultAsync(m => m.Id == id);
			if (supplier == null)
			{
				return NotFound();
			}

			return View(supplier);
		}

		// GET: Suppliers/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var supplier = await _db.Suppliers.FindAsync(id);
			if (supplier == null)
			{
				return NotFound();
			}
			return View(supplier);
		}

		// POST: Suppliers/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id,Suppliers supplier)
		{
			if (id != supplier.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_db.Update(supplier);
					await _db.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!SupplierExists(supplier.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(supplier);
		}

		// Método auxiliar para verificar si el proveedor existe
		private bool SupplierExists(int id)
		{
			return _db.Suppliers.Any(e => e.Id == id);
		}

		// GET: Suppliers/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var supplier = await _db.Suppliers
				.FirstOrDefaultAsync(m => m.Id == id);
			if (supplier == null)
			{
				return NotFound();
			}

			return View(supplier);
		}

		// POST: Suppliers/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var supplier = await _db.Suppliers.FindAsync(id);
			_db.Suppliers.Remove(supplier);
			await _db.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

	}
}