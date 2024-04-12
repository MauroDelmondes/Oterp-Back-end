using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OterpBackend.Models;

public class PurchaseOrder
{
  [Key]
  public int IDPurchaseOrder { get; set; }
  [Required]
  public int IDCompany { get; set; }
  [Required]
  public int IDProvider { get; set; }
  [Required]
  public int IDOrderStatus { get; set; }
  [Required]
  public DateTime OrderDate { get; set; }
  [Required]
  public decimal AmountValue { get; set; }
  [Required]
  public decimal AmountValueDiscount { get; set; }
  [Required]
  public decimal PercentageDiscount { get; set; }

  [ForeignKey("IDCompany")]
  public Company? Company { get; set; }
  [ForeignKey("IDProvider")]
  public Provider? Provider { get; set; }
  [ForeignKey("IDOrderStatus")]
  public OrderStatus? OrderStatus { get; set; }

  public ICollection<PurchaseOrderItem>? PurchaseOrderItems { get; set; }
  public ICollection<PurchaseOrderInstallment>? PurchaseOrderInstallments { get; set; }
}