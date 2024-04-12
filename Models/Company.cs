using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OterpBackend.Models;

public class Company
{
  [Key]
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
  public string? CompanyName { get; set; }
  [Required]
  public string? TradingName { get; set; }
  [Required]
  [StringLength(14)]
  public string? CNPJ { get; set; }
  [StringLength(50)]
  public string? Email { get; set; }
  [StringLength(25)]
  public string? PhoneNumber { get; set; }

  [ForeignKey("IDCountry")]
  public Country? Country { get; set; }
  [ForeignKey("IDState")]
  public State? State { get; set; }
  [ForeignKey("IDCity")]
  public City? City { get; set; }

  public ICollection<Provider>? Providers { get; set; }
  public ICollection<Customer>? Customers { get; set; }
}