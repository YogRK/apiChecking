using System.ComponentModel.DataAnnotations.Schema;
using PortfolioApi.SharedKernel;
using PortfolioApi.SharedKernel.Interfaces;

namespace PortfolioApi.Core.model;
public partial class Skills : BaseEntity, IAggregateRoot
{
  [ForeignKey("Users")]
  public virtual int UsersId { get; set; }

  public string? SkillName { get; set; }

  public string? SkillDescription { get; set; }
}
