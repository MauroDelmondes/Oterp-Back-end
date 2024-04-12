using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OterpBackend.Models;

public class ProductMovement
{
  [Key]
  public int IDProductMovement { get; set; }
  [Required]
  public int IDProduct { get; set; }
  public int? IDSaleOrder { get; set; }
  public int? IDPurchaseOrder { get; set; }
  [Required]
  public string? MovementType { get; set; }
  [Required]
  public int TotalAmount { get; set; }
  [Required]
  public DateTime MovementDate { get; set; }

  [ForeignKey("IDProduct")]
  public Product? Product { get; set; }
  [ForeignKey("IDSaleOrder")]
  public SaleOrder? SaleOrder { get; set; }
  [ForeignKey("IDPurchaseOrder")]
  public PurchaseOrder? PurchaseOrder { get; set; }
}