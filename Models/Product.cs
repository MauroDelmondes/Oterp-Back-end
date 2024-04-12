using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OterpBackend.Models;

public class Product
{
  [Key]
  public int IDProduct { get; set; }
  [Required]
  public int IDCompany { get; set; }
  [Required]
  public string? ProductDescription { get; set; }
  [Required]
  public decimal SalePrice { get; set; }
  [Required]
  public decimal PurchasePrice { get; set; }
  [Required]
  public int TotalAmount { get; set; }

  [ForeignKey("IDCompany")]
  public Company? Company { get; set; }
}