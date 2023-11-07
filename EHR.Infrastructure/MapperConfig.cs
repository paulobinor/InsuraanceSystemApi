using AutoMapper;
using EHR.Api.Dtos;
using EHR.AppService.Dtos;
using EHR.Core.Models;

namespace EHR.Infrastructure
{
    public class MapperConfig : Profile
    {
        public static IMapper InsuranceClaimMapper()
        {
            //Provide all the Mapping Configuration
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PolicyHolder, PolicyHolderDto>().ReverseMap();
                cfg.CreateMap<Claim, ClaimDto>().ReverseMap();
                cfg.CreateMap<Expense, ExpenseDto>().ReverseMap();
            }).CreateMapper();

            return mapper;
        }
    }
}
