using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
	public interface IMovieRepository
	{
		IEnumerable<Movie> GetAll();
		Movie? GetById(int id);
		void Insert(Movie Movie);
		void Update(Movie Movie);
		void Delete(int id);
		void Save();
	}
}
