using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NuGet.Protocol.Plugins;

namespace OterpBackend.Models;

public class User
{
  [Key]
  public int IDUser { get; set; }
  [ForeignKey("IDUserType")]
  public int IDUserType { get; set; }
  [ForeignKey("IDCompany")]
  public int IDCompany { get; set; }
  [ForeignKey("IDCountry")]
  public int IDCountry { get; set; }
  [ForeignKey("IDState")]
  public int IDState { get; set; }
  [ForeignKey("IDCity")]
  public int IDCity { get; set; }
  public string? PostalCode { get; set; }
  public string? Neighborhood { get; set; }
  public string? Street { get; set; }
  public int Number { get; set; }
  public string? AddressComplement { get; set; }
  public string? FirstName { get; set; }
  public string? LastName { get; set; }
  public DateOnly Birthdate { get; set; }
  public string? CPFCNPJ { get; set; }
  public string? Email { get; set; }
  public string? PhoneNumber { get; set; }
  public string? Login { get; set; }
  public string? Password { get; set; }

  public UserType? UserType { get; set; }
  public Company? Company { get; set; }
  public Country? Country { get; set; }
  public State? State { get; set; }
  public City? City { get; set; }
}