using InvenPro.Domain;
using InvenPro.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InvenPro.API.Controllers
{
	[ApiController]
	[Route("[Controller]")]
	public class SupplierController:ControllerBase
	{
		private readonly InvenProDbContext _context;

		public SupplierController(InvenProDbContext context)
        {
			_context = context;
		}

		[HttpGet("GetSuppliers")]
		public async Task<ActionResult<List<Suppliers>>> GetSuppliers()
		{
			var Suppliers = await _context.Suppliers.ToListAsync();
			return Suppliers;
		}
	}
}
