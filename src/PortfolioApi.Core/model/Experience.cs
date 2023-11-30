using System.ComponentModel.DataAnnotations.Schema;
using PortfolioApi.SharedKernel;
using PortfolioApi.SharedKernel.Interfaces;

namespace PortfolioApi.Core.model;
public partial class Experience : BaseEntity,IAggregateRoot
{
  [ForeignKey("Users")]
  public virtual int UsersId {  get; set; }

  public string? ExperienceDetail { get; set; } = null;

  public string? ExperienceIn { get; set; } = null;

  public string? ToolUsed { get; set; } = null;

  public DateTime? StartDate { get; set; } = null;

  public DateTime? EndDate { get; set; } = null;
}
