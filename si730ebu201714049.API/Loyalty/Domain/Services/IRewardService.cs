using si730ebu201714049.API.Loyalty.Domain.Models;
using si730ebu201714049.API.Loyalty.Domain.Services.Communication;

namespace si730ebu201714049.API.Loyalty.Domain.Services;

public interface IRewardService
{
    Task<IEnumerable<Reward>> ListAsync();
    Task<IEnumerable<Reward>> ListAsyncByScore(int score);
    
    Task<RewardResponse> SaveAsync(Reward reward,int id);
    
}