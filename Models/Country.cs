using System.ComponentModel.DataAnnotations;

namespace OterpBackend.Models;

public class Country
{
  [Key]
  public int IDCountry { get; set; }
  public string? CountryName { get; set; }

  public ICollection<State>? States { get; set; }
}