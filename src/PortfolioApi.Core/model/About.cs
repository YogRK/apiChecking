using System.ComponentModel.DataAnnotations.Schema;
using PortfolioApi.SharedKernel;
using PortfolioApi.SharedKernel.Interfaces;

namespace PortfolioApi.Core.model;
public partial class About : BaseEntity, IAggregateRoot
{
  [ForeignKey("Users")]
  public virtual int UsersId { get; set; }

  public string? AboutMe { get; set; }

  public string? Description { get; set;}
}
