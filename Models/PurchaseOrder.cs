using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OterpBackend.Models;

public class PurchaseOrder
{
  [Key]
  public int IDPurchaseOrder { get; set; }
  [ForeignKey("IDCompany")]
  public int IDCompany { get; set; }
  [ForeignKey("IDProvider")]
  public int IDProvider { get; set; }
  [ForeignKey("IDOrderStatus")]
  public int IDOrderStatus { get; set; }
  public DateTime OrderDate { get; set; }
  public decimal AmountValue { get; set; }
  public decimal AmountValueDiscount { get; set; }
  public decimal PercentageDiscount { get; set; }

  public Company? Company { get; set; }
  public Provider? Provider { get; set; }
  public OrderStatus? OrderStatus { get; set; }

  public ICollection<PurchaseOrderItem>? PurchaseOrderItems { get; set; }
  public ICollection<PurchaseOrderInstallment>? PurchaseOrderInstallments { get; set; }
}