using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace OterpBackend.Models;

public class PurchaseOrderItem
{
  [Key]
  public int IDPurchaseOrderItem { get; set; }
  [Required]
  public int IDPurchaseOrder { get; set; }
  [Required]
  public int IDProduct { get; set; }
  [Required]
  public int ProductQuantity { get; set; }
  [Required]
  public decimal ProductUnitPrice { get; set; }
  [Required]
  public decimal ProductUnitValueDiscount { get; set; }
  [Required]
  public decimal ProductUnitPercentageDiscount { get; set; }
  [Required]
  public decimal ProductAmountValue { get; set; }

  [ForeignKey("IDPurchaseOrder")]
  public PurchaseOrder? PurchaseOrder { get; set; }
  [ForeignKey("IDProduct")]
  public Product? Product { get; set; }
}