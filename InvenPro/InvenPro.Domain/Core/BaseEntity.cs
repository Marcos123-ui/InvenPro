﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenPro.Domain.Core
{
	public class BaseEntity
	{
        public int Id { get; set; }
        public string CreationDate { get; set; }
        public string CreatedBy { get; set; }



    }
}