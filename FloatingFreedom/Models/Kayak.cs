using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloatingFreedom.Models
{
	public class Kayak
	{
		public int Id { get; set; }
		public int KayakTypeId { get; set; }
		public string UserId { get; set; }
		public string Name { get; set; }
		public KayakType KayakType { get; set; }
	}
}
