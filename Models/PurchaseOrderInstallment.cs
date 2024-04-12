using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OterpBackend.Models;

public class PurchaseOrderInstallment
{
  [Key]
  public int IDPurchaseOrderInstallment { get; set; }
  [Required]
  public int IDPurchaseOrder { get; set; }
  [Required]
  public int InstallmentNumber { get; set; }
  [Required]
  public decimal InstallmentValue { get; set; }
  [Required]
  public DateTime InstallmentDueDate { get; set; }
  [Required]
  public bool IsPaidOut { get; set; }

  [ForeignKey("IDPurchaseOrder")]
  public PurchaseOrder? PurchaseOrder { get; set; }
}