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
		[Required]
		public int KayakTypeId { get; set; }
		[Display(Name = "User Name")]
		public string UserId { get; set; }
		[Required]
		[Display(Name = "Kayak Name")]
		public string Name { get; set; }
		[Required]
		[Display(Name = "Kayak Type")]
		public KayakType KayakType { get; set; }
		public List<Customer> customers { get; set; } = new List<Customer>();
		public ApplicationUser User { get; set; }
	}
}
