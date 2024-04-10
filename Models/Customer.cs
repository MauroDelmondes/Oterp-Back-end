using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OterpBackend.Models;

public class Customer
{
  [Key]
  public int IDCustomer { get; set; }
  [ForeignKey("IDCompany")]
  public int IDCompany { get; set; }
  public string? PostalCode { get; set; }
  public string? Street { get; set; }
  public int Number { get; set; }
  public string? FirstName { get; set; }
  public string? LastName { get; set; }
  public DateOnly Birthdate { get; set; }
  public string? CPF { get; set; }
  public string? Email { get; set; }
  public string? PhoneNumber { get; set; }

  public Company? Company { get; set; }
}