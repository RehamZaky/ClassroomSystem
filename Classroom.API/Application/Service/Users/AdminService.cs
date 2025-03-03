using AutoMapper;
using Classroom.API.Application.DTO;
using Classroom.API.Application.Repository.Interface;
using Classroom.API.Domain.Entities;

namespace Classroom.API.Application.Service.Users
{
    public class AdminService : IAdminService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAdminRepository _adminRepository ;
        public AdminService(IUnitOfWork unitOfWork, IMapper mapper, IAdminRepository adminRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _adminRepository = adminRepository;

        }

        public async Task<AdminDTO> CreateAdmin(AdminDTO adminDTO)
        {
            var user = _mapper.Map<User>(adminDTO);
            user.CreatedAt = DateTime.Now;
            var addedUser = await _unitOfWork.Repository<User>().AddAsync(user);
            if (addedUser == null)
            {
                return null;
            }


            var admin = _mapper.Map<Admin>(adminDTO);
            admin.UserId = addedUser.Id;

            var addedAdmin = await _unitOfWork.Repository<Admin>().AddAsync(admin);
            adminDTO.Password = "";
            return adminDTO;
        }


        public async Task<List<AdminUserDTO>> GetAllAdmins()
        {
           var users = await _adminRepository.GetAllAdmins();
            return _mapper.Map<List<AdminUserDTO>>(users);
        }
    }
}
