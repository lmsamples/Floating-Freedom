using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FloatingFreedom.Models
{
	public class Kayak
	{
		public int Id { get; set; }
		public int KayakTypeId { get; set; }
		public string UserId { get; set; }
		[Display(Name = "Kayak Name")]
		public string Name { get; set; }
		[Display(Name = "Kayak Type")]
		public KayakType KayakType { get; set; }
		public ApplicationUser User { get; set; }
	}
}
