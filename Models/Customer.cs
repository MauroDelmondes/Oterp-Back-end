using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OterpBackend.Models;

public class Customer
{
  [Key]
  public int IDCustomer { get; set; }
  [Required]
  public int IDCompany { get; set; }
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
  [StringLength(50)]
  public string? FirstName { get; set; }
  [Required]
  [StringLength(50)]
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

  [ForeignKey("IDCompany")]
  public Company? Company { get; set; }
}