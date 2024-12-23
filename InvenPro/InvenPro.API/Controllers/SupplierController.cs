﻿using InvenPro.Domain;
using InvenPro.Domain.Entities;
using InvenPro.Persistence;
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

		[HttpPost(nameof(AddSuppliers))]
		public async Task<ActionResult<Suppliers>> AddSuppliers(Suppliers supplier)
		{
			_context.Suppliers.Add(supplier);
			await _context.SaveChangesAsync();
			return supplier;
		}
	}
	



}

