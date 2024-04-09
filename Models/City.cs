using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Identity.Client;

namespace OterpBackend.Models;

public class City
{
  [Key]
  public int IDCity { get; set; }
  [ForeignKey("IDState")]
  public int IDState { get; set; }
  public string? CityName { get; set; }

  public State? State { get; set; }

  public ICollection<Company>? Companies { get; set; }
}