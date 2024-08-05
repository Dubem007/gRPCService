using ProductgRPCService.Entities;
using AutoMapper;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ProductgRPCService.Protos;

namespace ProductgRPCService.Mapper
{
    public class OfferMapper : Profile
    {
        public OfferMapper()
        {
            CreateMap<Offer, OfferDetail>().ReverseMap();
        }
    }
}
