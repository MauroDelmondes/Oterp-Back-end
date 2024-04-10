using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OterpBackend.Models;

public class SaleOrderInstallment
{
  [Key]
  public int IDSaleOrderInstallment { get; set; }
  [ForeignKey("IDSaleOrder")]
  public int IDSaleOrder { get; set; }
  public int InstallmentNumber { get; set; }
  public decimal InstallmentValue { get; set; }
  public DateTime InstallmentDueDate { get; set; }
  public bool IsPaidOut { get; set; }

  public SaleOrder? SaleOrder { get; set; }
}