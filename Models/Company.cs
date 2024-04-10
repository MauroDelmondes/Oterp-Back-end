using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OterpBackend.Models;

public class Company
{
  [Key]
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
  public string? CompanyName { get; set; }
  public string? TradingName { get; set; }
  public string? CNPJ { get; set; }
  public string? Email { get; set; }
  public string? PhoneNumber { get; set; }

  public Country? Country { get; set; }
  public State? State { get; set; }
  public City? City { get; set; }

  public ICollection<Provider>? Providers { get; set; }
  public ICollection<Customer>? Customers { get; set; }
}