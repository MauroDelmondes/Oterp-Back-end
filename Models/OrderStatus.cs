using System.ComponentModel.DataAnnotations;

namespace OterpBackend.Models;

public class OrderStatus
{
  [Key]
  public int IDOrderStatus { get; set; }
  public string? OrderStatusDescription { get; set; }
}