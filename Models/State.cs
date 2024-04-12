using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NuGet.Protocol.Plugins;

namespace OterpBackend.Models;

public class State
{
  [Key]
  public int IDState { get; set; }
  [Required]
  public int IDCountry { get; set; }
  [Required]
  public string? StateName { get; set; }

  [ForeignKey("IDCountry")]
  public Country? Country { get; set; }

  public ICollection<City>? Cities { get; set; }
}