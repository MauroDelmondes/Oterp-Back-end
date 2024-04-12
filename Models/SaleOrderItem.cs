using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace OterpBackend.Models;

public class SaleOrderItem
{
  [Key]
  public int IDSaleOrderItem { get; set; }
  [Required]
  public int IDSaleOrder { get; set; }
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

  [ForeignKey("IDSaleOrder")]
  public SaleOrder? SaleOrder { get; set; }
  [ForeignKey("IDProduct")]
  public Product? Product { get; set; }
}