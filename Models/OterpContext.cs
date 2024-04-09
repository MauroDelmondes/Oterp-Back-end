using Microsoft.EntityFrameworkCore;
using OterpBackend.Models;

public class OterpContext : DbContext
{
  public OterpContext(DbContextOptions<OterpContext> options)
    : base(options)
  {
  }

  public DbSet<Countries> CountriesList { get; set; } = null!;
  public DbSet<States> StatesList { get; set; } = null!;
  public DbSet<Cities> CitiesList { get; set; } = null!;
  public DbSet<Cities> CompaniesList { get; set; } = null!;

  public DbSet<OterpBackend.Models.Companies> Companies { get; set; } = default!;
}
