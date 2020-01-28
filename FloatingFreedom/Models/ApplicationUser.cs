using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace FloatingFreedom.Models
{
	public class ApplicationUser : IdentityUser
	{
		[Required]
		[Display(Name = "Store Name")]
		public string Name { get; set; }
		[Required]
		[Display(Name = "Street Address")]
		public string Address { get; set; }

		public virtual ICollection<Kayak> Kayaks { get; set; }
		public virtual ICollection<Customer> Customers { get; set; }
	}
}
