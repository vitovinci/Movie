using AutoMapper;
using BLL.Model;
using DAL.Entity;

namespace PL.Configuration
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieModel>().ReverseMap();
        }
    }
}
