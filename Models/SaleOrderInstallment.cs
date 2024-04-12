using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OterpBackend.Models;

public class SaleOrderInstallment
{
  [Key]
  public int IDSaleOrderInstallment { get; set; }
  [Required]
  public int IDSaleOrder { get; set; }
  [Required]
  public int InstallmentNumber { get; set; }
  [Required]
  public decimal InstallmentValue { get; set; }
  [Required]
  public DateTime InstallmentDueDate { get; set; }
  [Required]
  public bool IsPaidOut { get; set; }

  [ForeignKey("IDSaleOrder")]
  public SaleOrder? SaleOrder { get; set; }
}