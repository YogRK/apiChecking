namespace PortfolioApi.Web.ApiModels;

public class ExperienceDto
{
  public int UsersId { get; set; }

  public string? ExperienceDetail { get; set; } = null;

  public string? ExperienceIn { get; set; } = null;

  public string? ToolUsed { get; set; } = null;

  public DateTime? StartDate { get; set; } = null;

  public DateTime? EndDate { get; set; } = null;
}
