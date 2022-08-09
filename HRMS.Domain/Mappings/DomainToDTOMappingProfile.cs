using AutoMapper;
using HRMS.Domain.DTOs;
using HRMS.Domain.Entities;

namespace HRMS.Domain.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<Contract, ContractDTO>().ReverseMap();
        }
       
    }
}
