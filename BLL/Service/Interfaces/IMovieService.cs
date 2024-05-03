using BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Service.Interfaces
{
	public interface IMovieService
	{
		IEnumerable<MovieModel> GetMovies();
		MovieModel? GetById(int id);
		void Insert(MovieModel book);
		void Update(MovieModel book);
		void Delete(int id);
	}
}
