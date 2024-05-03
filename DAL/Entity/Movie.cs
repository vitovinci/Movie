using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
	public class Movie
	{
		[Key]
		public int Id { get; set; }
		public required string Title { get; set; }
		public string? Author { get; set; }

		public string? Category { get; set; }
		public DateTime Created { get; set; }
		public DateTime Updated { get; set; }
	}
}
