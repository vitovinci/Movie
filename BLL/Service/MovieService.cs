using AutoMapper;
using BLL.Model;
using BLL.Service.Interfaces;
using DAL.Entity;
using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
	public class MovieService(IMovieRepository repo, IMapper mapper) : IMovieService
	{
		private readonly IMovieRepository repo = repo;
		private readonly IMapper mapper = mapper;

		public void Delete(int id)
		{
			repo.Delete(id);
			repo.Save();
		}

		public IEnumerable<MovieModel> GetMovies() => [.. repo.GetAll().Select(mapper.Map<MovieModel>)];

		public MovieModel? GetById(int id) => mapper.Map<MovieModel>(repo.GetById(id));

		public void Insert(MovieModel Movie)
		{
			Movie.Created = DateTime.Now;
			Movie.Updated = DateTime.Now;
			repo.Insert(mapper.Map<Movie>(Movie));
			repo.Save();
		}

		public void Update(MovieModel Movie)
		{
			Movie entity = mapper.Map<Movie>(Movie);
			entity.Updated = DateTime.Now;
			repo.Update(entity);
			repo.Save();
		}
	}
}
