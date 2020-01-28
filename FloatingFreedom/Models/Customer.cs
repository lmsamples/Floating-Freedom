using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloatingFreedom.Models
{
	public class Customer
	{
		public int Id { get; set; }
		public string UserId { get; set; }
		public int KayakId { get; set; }
		public string Name { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public DateTime RentalDate { get; set; }
		public DateTime ReturnDate { get; set; }
		public Kayak Kayak { get; set; }
	}
}
