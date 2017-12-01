using Business.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
	public class Record
	{
		public int Id { get; set; }
		public object Content { get; set; }
		public DateTime Posted { get; set; }
		public PostType Type { get; set; }

	}
}
