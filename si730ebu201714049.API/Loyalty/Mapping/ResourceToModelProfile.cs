using AutoMapper;
using si730ebu201714049.API.Loyalty.Domain.Models;
using si730ebu201714049.API.Loyalty.Resources;

namespace si730ebu201714049.API.Loyalty.Mapping;

public class ResourceToModelProfile : Profile
{
    public ResourceToModelProfile()
    {       //               < origen, destino >
        CreateMap<SaveRewardResource, Reward>();
    }
}