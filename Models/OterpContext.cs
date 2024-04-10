using Microsoft.EntityFrameworkCore;
using OterpBackend.Models;

public class OterpContext : DbContext
{
  public OterpContext(DbContextOptions<OterpContext> options)
    : base(options)
  {
  }

  public DbSet<Country> CountryList { get; set; } = null!;
  public DbSet<State> StateList { get; set; } = null!;
  public DbSet<City> CityList { get; set; } = null!;
  public DbSet<Company> CompanyList { get; set; } = null!;
  public DbSet<Provider> ProviderList { get; set; } = null!;
  public DbSet<UserType> UserTypeList { get; set; } = null!;
  public DbSet<User> UserList { get; set; } = null!;
  public DbSet<Product> ProductList { get; set; } = null!;
  public DbSet<OrderStatus> OrderStatusList { get; set; } = null!;
  public DbSet<PurchaseOrder> PurchaseOrderList { get; set; } = null!;
  public DbSet<PurchaseOrderItem> PurchaseOrderItemList { get; set; } = null!;
  public DbSet<PurchaseOrderInstallment> PurchaseOrderInstallmentList { get; set; } = null!;
  public DbSet<Customer> CustomerList { get; set; } = null!;
  public DbSet<SaleOrder> SaleOrderList { get; set; } = null!;
  public DbSet<SaleOrderItem> SaleOrderItemList { get; set; } = null!;
  public DbSet<SaleOrderInstallment> SaleOrderInstallmentList { get; set; } = null!;
  public DbSet<ProductMovement> ProductMovementList { get; set; } = null!;
}