using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NuGet.Protocol.Plugins;

namespace OterpBackend.Models;

public class User
{
  [Key]
  public int IDUser { get; set; }
  [Required]
  public int IDUserType { get; set; }
  [Required]
  public int IDCompany { get; set; }
  [Required]
  public int IDCountry { get; set; }
  [Required]
  public int IDState { get; set; }
  [Required]
  public int IDCity { get; set; }
  [Required]
  [StringLength(8)]
  public string? PostalCode { get; set; }
  [Required]
  public string? Neighborhood { get; set; }
  [Required]
  public string? Street { get; set; }
  [Required]
  public int Number { get; set; }
  public string? AddressComplement { get; set; }
  [Required]
  public string? FirstName { get; set; }
  [Required]
  public string? LastName { get; set; }
  [Required]
  public DateOnly Birthdate { get; set; }
  [Required]
  [StringLength(14)]
  public string? CPFCNPJ { get; set; }
  [Required]
  [StringLength(50)]
  public string? Email { get; set; }
  [Required]
  [StringLength(25)]
  public string? PhoneNumber { get; set; }
  [Required]
  [StringLength(50)]
  public string? Login { get; set; }
  [Required]
  [StringLength(100)]
  public string? Password { get; set; }

  [ForeignKey("IDUserType")]
  public UserType? UserType { get; set; }
  [ForeignKey("IDCompany")]
  public Company? Company { get; set; }
  [ForeignKey("IDCountry")]
  public Country? Country { get; set; }
  [ForeignKey("IDState")]
  public State? State { get; set; }
  [ForeignKey("IDCity")]
  public City? City { get; set; }
}