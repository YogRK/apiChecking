using System.ComponentModel.DataAnnotations;

namespace PortfolioApi.Web.ApiModels;

public class AboutDto
{
  [Required]
  public int UserId { get; set; }

  public string? AboutUsers { get; set; }

  public string? Description { get; set; }
}
