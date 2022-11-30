using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using si730ebu201714049.API.Loyalty.Domain.Models;
using si730ebu201714049.API.Loyalty.Domain.Services;
using si730ebu201714049.API.Loyalty.Resources;
using si730ebu201714049.API.Shared.Extensions;

namespace si730ebu201714049.API.Loyalty.Controller;


[ApiController]
[Route("/api/v1/fleets/{fleetId}/[controller]")]
public class RewardsController : ControllerBase
{
    private readonly IRewardService _rewardService; 
    private readonly IMapper _mapper;


    public RewardsController(IRewardService rewardService, IMapper mapper)
    {
        _rewardService = rewardService;
        _mapper = mapper;
    }

    [HttpPost("{fleetId}")]
    [ProducesResponseType(typeof(RewardResource), 201)]
    [ProducesResponseType(typeof(List<string>), 400)]
    [ProducesResponseType(500)]
    public async Task<IActionResult> PostAsync([FromBody] SaveRewardResource resource, int fleetId)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessages());
        
        var reward = _mapper.Map<SaveRewardResource,Reward>(resource);
        var result = await _rewardService.SaveAsync(reward,fleetId);

        if (!result.Success) return BadRequest(result.Message);

        var rewardResource = _mapper.Map<Reward, RewardResource>(result.Resource);
        return Created(nameof(PostAsync), rewardResource);
    }





}