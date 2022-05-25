using AutoMapper;
using DealStoreweb.Backend.Models;

namespace DealStoreweb.Backend.Deal
{
    public class DealProfile : Profile
    {
        public DealProfile()
        {
            CreateMap<ServiceTbl, Deal>();
            CreateMap<Deal, ServiceTbl>();
        }
    }
}