using System.ComponentModel.DataAnnotations;

namespace OterpBackend.Models;

public class Countries
{
  [Key]
  public int IDCountry { get; set; }
  public string? CountryName { get; set; }
}