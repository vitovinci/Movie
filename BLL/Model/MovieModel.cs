using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
	public class MovieModel
	{
		public int Id { get; set; }
		public required string Title { get; set; }
		public string? Author { get; set; }
		public string? Category { get; set; }
		public DateTime Created { get; set; } = DateTime.Now;
		public DateTime Updated { get; set; } = DateTime.Now;
	}
}
