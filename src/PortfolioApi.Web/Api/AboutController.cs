using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PortfolioApi.Core.model;
using PortfolioApi.SharedKernel.Interfaces;
using PortfolioApi.Web.ApiModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PortfolioApi.Web.Api;
[Route("api/[controller]")]
[Produces("application/json")]
[ApiController]
public class AboutController : BaseApiController
{
  private readonly IRepository<About> _aboutRepository;
  public AboutController(IRepository<About> aboutRepository)
  {
    _aboutRepository = aboutRepository;
  }
  
  // GET api/<UsersController>/5
  [HttpGet("{id}")]
  public async Task<IActionResult> Get(int id)
  {
    try
    {
      About? user = await _aboutRepository.GetByIdAsync(id);
      if (user == null)
      {
        return NotFound();
      }
      return Ok(user);
    }
    catch (Exception ex)
    {
      return Ok(ex);
    }
  }

  // POST api/<UsersController>
  [HttpPost]
  public async Task<IActionResult> Post([FromBody] AboutDto value)
  {
    try
    {
      About about = new About
      {
        UsersId = value.UserId,
        AboutMe = value.AboutUsers,
        Description = value.Description,
        CreatedDate = DateTime.Now
      };
      await _aboutRepository.AddAsync(about);
      return Ok(about);
    }
    catch (Exception ex)
    {
      return Ok(ex);
    }
  }

  // PUT api/<UsersController>/5
  [HttpPut("{id}")]
  public async Task<IActionResult> Put(int id, [FromBody] AboutDto value)
  {
    try
    {
      About? about = await _aboutRepository.GetByIdAsync(id);
      if (about == null)
      {
        return NotFound();
      }
      about.UsersId = value.UserId;
      about.AboutMe = value.AboutUsers;
      about.Description = value.Description;
      about.ModifiedDate = DateTime.Now;
      await _aboutRepository.UpdateAsync(about);
      return Ok(about);
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
      About? about = await _aboutRepository.GetByIdAsync(id);
      if (about == null)
      {
        return NotFound();
      }

      await _aboutRepository.DeleteAsync(about);
      return Ok(about.Id);
    }
    catch (Exception ex)
    {
      return Ok(ex);
    }
  }
}
