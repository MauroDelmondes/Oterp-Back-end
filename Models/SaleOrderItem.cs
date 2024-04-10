using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace OterpBackend.Models;

public class SaleOrderItem
{
  [Key]
  public int IDSaleOrderItem { get; set; }
  [ForeignKey("IDSaleOrder")]
  public int IDSaleOrder { get; set; }
  [ForeignKey("IDProduct")]
  public int IDProduct { get; set; }
  public int ProductQuantity { get; set; }
  public decimal ProductUnitPrice { get; set; }
  public decimal ProductUnitValueDiscount { get; set; }
  public decimal ProductUnitPercentageDiscount { get; set; }
  public decimal ProductAmountValue { get; set; }

  public SaleOrder? SaleOrder { get; set; }
  public Product? Product { get; set; }
}