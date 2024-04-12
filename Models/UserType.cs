using System.ComponentModel.DataAnnotations;

namespace OterpBackend.Models;

public class UserType
{
  [Key]
  public int IDUserType { get; set; }
  [Required]
  public string? UserTypeDescription { get; set; }

  public ICollection<User>? Users { get; set; }
}