using Microsoft.AspNetCore.Mvc;
using PortfolioApi.Core.model;
using PortfolioApi.Core.ProjectAggregate.Specifications;
using PortfolioApi.SharedKernel.Interfaces;
using PortfolioApi.Web.ApiModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PortfolioApi.Web.Api;
[Route("api/[controller]")]
[Produces("application/json")]
[ApiController]
public class UsersController : BaseApiController
{
  private readonly IRepository<Users> _userRepository;
  public UsersController(IRepository<Users> userrepository)
  {
    _userRepository = userrepository;
  }
  // GET: api/<UsersController>
  [HttpGet]
  public async Task<IActionResult> Get()
  {
    try {
      List<Users> userDetails = await _userRepository.ListAsync();
      return Ok(userDetails);
    }
    catch (Exception ex)
    {
      return Ok(ex);
    }    
    
  }

  // GET api/<UsersController>/5
  [HttpGet("{id}")]
  public async Task<IActionResult> Get(int id)
  {
    try
    {
      var userSpec = new UsersByIdWithItemSpec(id);
      Users? user = await _userRepository.GetBySpecAsync(userSpec);
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
  public async Task<IActionResult> Post([FromBody] UsersDto value)
  {
    try
    {
      Users user = new Users
      {
        FirstName = value.FirstName,
        LastName = value.LastName,
        Email = value.Email,
        Password = value.Password,
        Address = value.Address,
        CreatedDate = DateTime.Now
      };
      await _userRepository.AddAsync(user);
      return Ok(user);
    }
    catch (Exception ex)
    {
      return Ok(ex);
    }
  }

  // PUT api/<UsersController>/5
  [HttpPut("{id}")]
  public async Task<IActionResult> Put(int id, [FromBody] UsersDto value)
  {
    try
    {
      Users? user = await _userRepository.GetByIdAsync(id);
      if(user== null)
      {
        return NotFound();
      }
      user.FirstName = value.FirstName;
      user.LastName = value.LastName;
      user.Email = value.Email;
      user.Password = value.Password;
      user.Address = value.Address;
      user.ModifiedDate = DateTime.Now;
      await _userRepository.UpdateAsync(user);
      return Ok(user);
    }
    catch (Exception ex)
    {
      return Ok(ex) ;
    }
  }

  // DELETE api/<UsersController>/5
  [HttpDelete("{id}")]
  public async Task<IActionResult> Delete(int id)
  {
    try
    {
      Users? user = await _userRepository.GetByIdAsync(id);
      if (user == null)
      {
        return NotFound();
      }

      await _userRepository.DeleteAsync(user);
      return Ok(user.Id);
    }
    catch (Exception ex)
    {
      return Ok(ex);
    }
  }
}
