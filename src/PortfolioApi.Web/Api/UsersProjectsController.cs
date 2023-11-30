using Microsoft.AspNetCore.Mvc;
using PortfolioApi.Core.model;
using PortfolioApi.SharedKernel.Interfaces;
using PortfolioApi.Web.ApiModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PortfolioApi.Web.Api;
[Route("api/[controller]")]
[Produces("application/json")]
[ApiController]
public class UsersProjectsController : ControllerBase
{
  private readonly IRepository<UsersProjects> _usersProjectsRepository;
  public UsersProjectsController(IRepository<UsersProjects> usersProjectsRepository)
  {
    _usersProjectsRepository = usersProjectsRepository;
  }

  // GET api/<UsersController>/5
  [HttpGet("{id}")]
  public async Task<IActionResult> Get(int id)
  {
    try
    {
      UsersProjects? usersProjects = await _usersProjectsRepository.GetByIdAsync(id);
      if (usersProjects == null)
      {
        return NotFound();
      }
      return Ok(usersProjects);
    }
    catch (Exception ex)
    {
      return Ok(ex);
    }
  }

  // POST api/<UsersController>
  [HttpPost]
  public async Task<IActionResult> Post([FromBody] UsersProjectsDto value)
  {
    try
    {
      UsersProjects usersProjects = new UsersProjects
      {
        UsersId = value.UsersId,
        ProjectName = value.ProjectName,
        ProjectDescription = value.ProjectDescription,
        ProjectDurations = value.ProjectDurations,
        StartDate = value.StartDate,
        EndDate = value.EndDate,
        CreatedDate = DateTime.Now
      };
      await _usersProjectsRepository.AddAsync(usersProjects);
      return Ok(usersProjects);
    }
    catch (Exception ex)
    {
      return Ok(ex);
    }
  }

  // PUT api/<UsersController>/5
  [HttpPut("{id}")]
  public async Task<IActionResult> Put(int id, [FromBody] UsersProjectsDto value)
  {
    try
    {
      UsersProjects? usersProjects = await _usersProjectsRepository.GetByIdAsync(id);
      if (usersProjects == null)
      {
        return NotFound();
      }
      usersProjects.UsersId = value.UsersId;
      usersProjects.ProjectDurations = value.ProjectDurations;
      usersProjects.ProjectDescription = value.ProjectDescription;
      usersProjects.ProjectName = value.ProjectName;
      usersProjects.StartDate = value.StartDate;
      usersProjects.EndDate = value.EndDate;
      usersProjects.ModifiedDate = DateTime.Now;
      await _usersProjectsRepository.UpdateAsync(usersProjects);
      return Ok(usersProjects);
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
      UsersProjects? usersProjects = await _usersProjectsRepository.GetByIdAsync(id);
      if (usersProjects == null)
      {
        return NotFound();
      }

      await _usersProjectsRepository.DeleteAsync(usersProjects);
      return Ok(usersProjects.Id);
    }
    catch (Exception ex)
    {
      return Ok(ex);
    }
  }
}
