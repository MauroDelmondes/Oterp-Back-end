using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Identity.Client;

namespace OterpBackend.Models;

public class Cities
{
  [Key]
  public int IDCity { get; set; }
  public int IDState { get; set; }
  public string? CityName { get; set; }

  [ForeignKey("IDState")]
  public States? states { get; set; }
}