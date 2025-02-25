using AutoMapper;
using Classroom.API.Application.DTO;
using Classroom.API.Application.Repository.Interface;
using Classroom.API.Application.Service.Users;
using Classroom.API.Domain.Entities;
using Classroom.API.Infrastructure.Presistance.Ropository;

namespace Classroom.API.Application.Automapper
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<Parent,ParentDTO>().ReverseMap();
            CreateMap<User,ParentDTO>().ReverseMap();
            CreateMap<Parent,ParentUpdateDTO>().ReverseMap();
            CreateMap<User,ParentUpdateDTO>().ReverseMap();

            CreateMap<Student, StudentDTO>().ReverseMap();
            CreateMap<User, StudentDTO>().ReverseMap();
            CreateMap<Student, StudentUpdateDTO>().ReverseMap();
            CreateMap<User, StudentUpdateDTO>().ReverseMap();
        }
    }
}
