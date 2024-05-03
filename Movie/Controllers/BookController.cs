using BLL.Model;
using BLL.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
	[Route("API/[controller]")]
	[ApiController]
	public class MovieController(IMovieService service) : ControllerBase
	{
		private readonly IMovieService service = service;

		[HttpGet("Get")]
		public IActionResult Get(int id) => Ok(service.GetById(id));

		[HttpGet("All")]
		public IActionResult GetAll() => Ok(service.GetMovies());

		[HttpPost("Create")]
		public IActionResult Insert(MovieModel Movie)
		{
			service.Insert(Movie);
			return Ok();
		}

		[HttpPut("Update")]
		public IActionResult Update(MovieModel Movie)
		{
			service.Update(Movie);
			return Ok();
		}

		[HttpDelete("Delete")]
		public IActionResult Delete(int id)
		{
			service.Delete(id);
			return Ok();
		}
	}
}
