using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class MovieDbContext(DbContextOptions options) : DbContext(options)
	{
		public DbSet<Movie> Movies { get; set; }
	}
}
