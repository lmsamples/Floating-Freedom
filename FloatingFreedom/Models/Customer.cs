using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FloatingFreedom.Models
{
	public class Customer
	{
		public int Id { get; set; }
		[Display(Name = "User Name")]
		public string UserId { get; set; }
		public int KayakId { get; set; }
		[Display(Name = "Customer Name")]
		public string Name { get; set; }
		[Display(Name = "Phone Number")]
		public string PhoneNumber { get; set; }
		[Display(Name = "Email Adress")]
		public string Email { get; set; }
		[Display(Name = "Rental Date")]
		public DateTime RentalDate { get; set; }
		[Display(Name = "Return Date")]
		public DateTime ReturnDate { get; set; }
		public Kayak Kayak { get; set; }
		public ApplicationUser User { get; set; }
	}
}
