using AutoMapper;
using Classroom.API.Application.DTO;
using Classroom.API.Domain.Entities;

namespace Classroom.API.Application.Automapper
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<Parent,ParentDTO>().ReverseMap();
            CreateMap<User,ParentDTO>().ReverseMap();
        }
    }
}
