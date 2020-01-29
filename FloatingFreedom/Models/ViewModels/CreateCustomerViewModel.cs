using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FloatingFreedom.Models.ViewModels
{
	public class CreateCustomerViewModel
	{
		public List<SelectListItem> Kayaks { get; set; }
		public Customer Customer { get; set; }
	}
}
