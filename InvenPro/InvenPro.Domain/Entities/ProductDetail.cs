using InvenPro.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenPro.Domain.Entities
{
	public class ProductDetail:BaseEntity
	{

        public int id { get; set; }
        public string itemDescription { get; set; }
    }
}
