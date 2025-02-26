using AutoMapper;
using Classroom.API.Application.DTO;
using Classroom.API.Application.Repository.Interface;
using Classroom.API.Domain.Entities;
using Classroom.API.Infrastructure.Presistance.Ropository;
using NPOI.POIFS.Properties;

namespace Classroom.API.Application.Service.Users
{
    public class ParentService : IParentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IParentRepository _parentRepository;
        public ParentService(IUnitOfWork unitOfWork,IMapper mapper,IParentRepository parentRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        _parentRepository = parentRepository;
        }
        public async Task<ParentDTO> CreateParent(ParentDTO parentDTO)
        {
            var user = _mapper.Map<User>(parentDTO); 
            user.CreatedAt = DateTime.Now;
            var addedUser = await _unitOfWork.Repository<User>().AddAsync(user);
            if(addedUser == null)
            { return null; }

            var parent = _mapper.Map<Domain.Entities.Parent>(parentDTO);
            parent.userId = addedUser.Id;

            await _unitOfWork.Repository<Domain.Entities.Parent>().AddAsync(parent);
           return _mapper.Map<ParentDTO>(addedUser);
        }

        public async Task<ParentUpdateDTO> UpdateParent(ParentUpdateDTO parentDTO)
        {
           var parentDb = await _unitOfWork.Repository<Domain.Entities.Parent>().GetByIdAsync(parentDTO.Id);
            if (parentDb == null)
                throw new KeyNotFoundException();

            var user = _mapper.Map<User>(parentDTO);
            user.UpdatedAt = DateTime.Now;
            await _unitOfWork.Repository<User>().UpdateAsync(user);


            _mapper.Map(parentDTO, parentDb);
            await _unitOfWork.Repository<Domain.Entities.Parent>().UpdateAsync(parentDb);
            return parentDTO;

        }

        public List<ParentDTO> GetAllParentsWithUser()
        {
            var parents = _parentRepository.GetAllParentsWithUser();
            return _mapper.Map<List<ParentDTO>>(parents);
        }

        public ParentDTO DeActivateParent(int id)
        {
            var parent = _parentRepository.DeActivateParent(id);
            if (parent == null)
                throw new KeyNotFoundException("parent not found");

            var parentDTO = _mapper.Map<ParentDTO>(parent);
            return parentDTO;

        }
    }
}
