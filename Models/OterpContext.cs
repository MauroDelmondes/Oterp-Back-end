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
  public DbSet<UserType> UserTypeList { get; set; } = null!;
  public DbSet<User> UserList { get; set; } = null!;
  public DbSet<Product> ProductList { get; set; } = null!;
}