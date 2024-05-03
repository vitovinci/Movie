using DAL.Entity;
using DAL.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
	public class MovieRepository(MovieDbContext context) : IMovieRepository
	{
		private readonly MovieDbContext context = context;
		private readonly DbSet<Movie> Movies = context.Set<Movie>();

		public void Delete(int id)
		{
			Movie Movie = Movies.Find(id);
			if (Movie != null)
				Movies.Remove(Movie);
		}

		public IEnumerable<Movie> GetAll() => [.. Movies];

		public Movie? GetById(int id) => Movies.Find(id);

		public void Insert(Movie Movie) => Movies.Add(Movie);

		public void Save() => context.SaveChanges();

		public void Update(Movie Movie)
		{
			context.Entry(Movie).State = EntityState.Modified;
			context.Update(Movie);
		}
	}
}
