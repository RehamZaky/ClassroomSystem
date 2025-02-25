using AutoMapper;
using Classroom.API.Application.DTO;
using Classroom.API.Application.Repository.Interface;
using Classroom.API.Domain.Entities;

namespace Classroom.API.Application.Service.Classroom
{
    public class ClassroomService : IClassroomService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ClassroomService(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<ClassroomDTO> createClassroom(ClassroomDTO classroomDTO)
        {
         
            var classR = _mapper.Map<Domain.Entities.Classroom>(classroomDTO);
       
            var class_rrom = await _unitOfWork.Repository<Domain.Entities.Classroom>().AddAsync(classR);
            var classRdto = _mapper.Map<ClassroomDTO>(classR);
            return classRdto;
        }
    }
}
