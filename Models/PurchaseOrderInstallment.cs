using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OterpBackend.Models;

public class PurchaseOrderInstallment
{
  [Key]
  public int IDPurchaseOrderInstallment { get; set; }
  [ForeignKey("IDPurchaseOrder")]
  public int IDPurchaseOrder { get; set; }
  public int InstallmentNumber { get; set; }
  public decimal InstallmentValue { get; set; }
  public DateTime InstallmentDueDate { get; set; }
  public bool IsPaidOut { get; set; }

  public PurchaseOrder? PurchaseOrder { get; set; }
}