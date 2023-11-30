using System.ComponentModel.DataAnnotations;

namespace PortfolioApi.Web.ApiModels;

public class UsersDto
{
  public string? FirstName { get; set; }

  public string? LastName { get; set; }

  [Required]
  public string Email { get; set; } = string.Empty;

  public string? Contact { get; set; }

  [Required]
  public string Password { get; set; } = string.Empty;

  public string? Address { get; set; }
}
