using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NuGet.Protocol.Plugins;

namespace OterpBackend.Models;

public class State
{
  [Key]
  public int IDState { get; set; }
  [ForeignKey("IDCountry")]
  public int IDCountry { get; set; }
  public string? StateName { get; set; }

  public Country? Country { get; set; }

  public ICollection<City>? Cities { get; set; }
}