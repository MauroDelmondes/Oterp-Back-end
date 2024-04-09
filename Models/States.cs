using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NuGet.Protocol.Plugins;

namespace OterpBackend.Models;

public class States
{
  [Key]
  public int IDState { get; set; }
  [ForeignKey("IDCountry")]
  public int IDCountry { get; set; }
  public string? StateName { get; set; }

  public Countries? Countries { get; set; }

  public ICollection<Cities>? CitiesList { get; set; }
}