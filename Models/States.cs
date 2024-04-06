using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NuGet.Protocol.Plugins;

namespace OterpBackend.Models;

public class States
{
  [Key]
  public int IDState { get; set; }
  public int IDCountry { get; set; }
  public string? StateName { get; set; }

  [ForeignKey("IDCountry")]
  public Countries? Countries { get; set; }
}