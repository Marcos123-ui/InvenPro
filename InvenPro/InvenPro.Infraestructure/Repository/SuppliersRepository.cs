using InvenPro.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenPro.Infraestructure.Repository
{
	public class SuppliersRepository
	{
		private readonly InvenProDbContext _context;

		public SuppliersRepository(InvenProDbContext context)
        {
			_context = context;
		}
    }
}
