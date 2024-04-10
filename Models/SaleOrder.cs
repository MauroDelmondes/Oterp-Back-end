using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OterpBackend.Models;

public class SaleOrder
{
  [Key]
  public int IDSaleOrder { get; set; }
  [ForeignKey("IDCustomer")]
  public int IDCustomer { get; set; }
  [ForeignKey("IDCompany")]
  public int IDCompany { get; set; }
  [ForeignKey("IDOrderStatus")]
  public int IDOrderStatus { get; set; }
  public DateTime OrderDate { get; set; }
  public decimal AmountValue { get; set; }
  public decimal AmountValueDiscount { get; set; }
  public decimal PercentageDiscount { get; set; }

  public Company? Company { get; set; }
  public Customer? customer { get; set; }
  public OrderStatus? OrderStatus { get; set; }

  public ICollection<SaleOrderItem>? SaleOrderItems { get; set; }
  public ICollection<SaleOrderInstallment>? SaleOrderInstallments { get; set; }
}