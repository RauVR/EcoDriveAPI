using AutoMapper;
using si730ebu201714049.API.Loyalty.Domain.Models;
using si730ebu201714049.API.Loyalty.Resources;

namespace si730ebu201714049.API.Loyalty.Mapping;

public class ModelToResourceProfile : Profile
{
    public ModelToResourceProfile()
    {   //      < origen, destino >
        CreateMap<Reward, RewardResource>();
    }
}