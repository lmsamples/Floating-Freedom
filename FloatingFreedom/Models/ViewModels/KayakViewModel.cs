using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FloatingFreedom.Models.ViewModels
{
	public class KayakViewModel
	{
		public List<SelectListItem> KayakTypes { get; set; }
		public Kayak Kayak { get; set; }
	}
}
