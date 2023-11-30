using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioApi.SharedKernel;
using PortfolioApi.SharedKernel.Interfaces;

namespace PortfolioApi.Core.model;
public partial class UsersProjects : BaseEntity, IAggregateRoot
{

  [ForeignKey("Users")]
  public virtual int UsersId { get; set; }

  public string? ProjectName {  get; set; }

  public string? ProjectDescription { get; set; }

  public string? ProjectDurations { get; set; }

  public DateTime? StartDate { get; set; }

  public DateTime? EndDate { get; set;}
}
