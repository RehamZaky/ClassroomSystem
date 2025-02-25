using AutoMapper;
using Classroom.API.Application.DTO;
using Classroom.API.Domain.Entities;

namespace Classroom.API.Application.Automapper
{
    public class ClassroomProfile : Profile
    {
        public ClassroomProfile()
        {
            CreateMap<ClassroomDTO, Domain.Entities.Classroom>().ReverseMap();
        }
    }
}
