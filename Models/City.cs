using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Identity.Client;

namespace OterpBackend.Models;

public class City
{
  [Key]
  public int IDCity { get; set; }
  [Required]
  public int IDState { get; set; }
  [Required]
  public string? CityName { get; set; }

  [ForeignKey("IDState")]
  public State? State { get; set; }

  public ICollection<Company>? Companies { get; set; }
}