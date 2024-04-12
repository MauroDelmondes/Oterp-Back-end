using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OterpBackend.Models;

public class SaleOrder
{
  [Key]
  public int IDSaleOrder { get; set; }
  [Required]
  public int IDCustomer { get; set; }
  [Required]
  public int IDCompany { get; set; }
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
  [ForeignKey("IDCustomer")]
  public Customer? Customer { get; set; }
  [ForeignKey("IDOrderStatus")]
  public OrderStatus? OrderStatus { get; set; }

  public ICollection<SaleOrderItem>? SaleOrderItems { get; set; }
  public ICollection<SaleOrderInstallment>? SaleOrderInstallments { get; set; }
}