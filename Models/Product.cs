using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OterpBackend.Models;

public class Product
{
  [Key]
  public int IDProduct { get; set; }
  [ForeignKey("IDCompany")]
  public int IDCompany { get; set; }
  public string? ProductDescription { get; set; }
  public decimal SalePrice { get; set; }
  public decimal PurchasePrice { get; set; }
  public int TotalAmount { get; set; }

  public Company? Company { get; set; }
}