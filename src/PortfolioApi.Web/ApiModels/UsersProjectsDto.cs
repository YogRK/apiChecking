namespace PortfolioApi.Web.ApiModels;

public class UsersProjectsDto
{
  public virtual int UsersId { get; set; }

  public string? ProjectName { get; set; }

  public string? ProjectDescription { get; set; }

  public string? ProjectDurations { get; set; }

  public DateTime? StartDate { get; set; }

  public DateTime? EndDate { get; set; }
}
