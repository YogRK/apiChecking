using Microsoft.AspNetCore.Mvc;
using PortfolioApi.Core.model;
using PortfolioApi.SharedKernel.Interfaces;
using PortfolioApi.Web.ApiModels;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PortfolioApi.Web.Api;
[Route("api/[controller]")]
[Produces("application/json")]
[ApiController]
public class ExperienceController : BaseApiController
{
  private readonly IRepository<Experience> _experienceRepository;
  public ExperienceController(IRepository<Experience> experienceRepository)
  {
    _experienceRepository = experienceRepository;
  }

  // GET api/<UsersController>/5
  [HttpGet("{id}")]
  public async Task<IActionResult> Get(int id)
  {
    try
    {
      Experience? experience = await _experienceRepository.GetByIdAsync(id);
      if (experience == null)
      {
        return NotFound();
      }
      return Ok(experience);
    }
    catch (Exception ex)
    {
      return Ok(ex);
    }
  }

  // POST api/<UsersController>
  [HttpPost]
  public async Task<IActionResult> Post([FromBody] ExperienceDto value)
  {
    try
    {
      Experience experience = new Experience
      {
        UsersId = value.UsersId,
        ExperienceDetail = value.ExperienceDetail,
        ExperienceIn = value.ExperienceIn,
        ToolUsed = value.ToolUsed,
        StartDate = value.StartDate,
        EndDate = value.EndDate,
        CreatedDate = DateTime.Now
      };
      await _experienceRepository.AddAsync(experience);
      return Ok(experience);
    }
    catch (Exception ex)
    {
      return Ok(ex);
    }
  }

  // PUT api/<UsersController>/5
  [HttpPut("{id}")]
  public async Task<IActionResult> Put(int id, [FromBody] ExperienceDto value)
  {
    try
    {
      Experience? experience = await _experienceRepository.GetByIdAsync(id);
      if (experience == null)
      {
        return NotFound();
      }
      experience.UsersId = value.UsersId;
      experience.ExperienceDetail = value.ExperienceDetail;
      experience.ExperienceIn = value.ExperienceIn;
      experience.ExperienceIn = value.ExperienceIn;
      experience.ToolUsed = value.ToolUsed;
      experience.StartDate = value.StartDate;
      experience.EndDate = value.EndDate;
      experience.ModifiedDate = DateTime.Now;
      await _experienceRepository.UpdateAsync(experience);
      return Ok(experience);
    }
    catch (Exception ex)
    {
      return Ok(ex);
    }
  }

  // DELETE api/<UsersController>/5
  [HttpDelete("{id}")]
  public async Task<IActionResult> Delete(int id)
  {
    try
    {
      Experience? experience = await _experienceRepository.GetByIdAsync(id);
      if (experience == null)
      {
        return NotFound();
      }

      await _experienceRepository.DeleteAsync(experience);
      return Ok(experience.Id);
    }
    catch (Exception ex)
    {
      return Ok(ex);
    }
  }
}
