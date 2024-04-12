using System.ComponentModel.DataAnnotations;

namespace OterpBackend.Models;

public class OrderStatus
{
  [Key]
  public int IDOrderStatus { get; set; }
  [Required]
  public string? OrderStatusDescription { get; set; }
}