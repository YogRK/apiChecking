
using PortfolioApi.SharedKernel;
using PortfolioApi.SharedKernel.Interfaces;

namespace PortfolioApi.Core.model;

public partial class Users : BaseEntity, IAggregateRoot
{
  
  public string? FirstName { get; set; }

  public string? LastName { get; set; }

  public string Email { get; set; } = "sample@gmail.com";

  public string? Contact { get; set; }

  public string Password { get; set; } = "sample@123";

  public string? Address { get; set; }

  public virtual ICollection<UsersProjects>? UsersProjects { get; } = null;

  public virtual ICollection<Skills>? GetSkills { get; } = null;

  public virtual ICollection<Experience>? Experience { get; } = null;

  public virtual ICollection<About>? About { get; } = null;
}
