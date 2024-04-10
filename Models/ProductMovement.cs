using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OterpBackend.Models;

public class ProductMovement
{
  [Key]
  public int IDProductMovement { get; set; }
  [ForeignKey("IDProduct")]
  public int IDProduct { get; set; }
  [ForeignKey("IDSaleOrder")]
  public int? IDSaleOrder { get; set; }
  [ForeignKey("IDPurchaseOrder")]
  public int? IDPurchaseOrder { get; set; }
  public string? MovementType { get; set; }
  public int TotalAmount { get; set; }
  public DateTime MovementDate { get; set; }

  public Product? Product { get; set; }
  public SaleOrder? SaleOrder { get; set; }
  public PurchaseOrder? PurchaseOrder { get; set; }
}