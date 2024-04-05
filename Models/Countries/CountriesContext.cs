using Microsoft.EntityFrameworkCore;

namespace OterpBackend.Models;

public class CountriesContext : DbContext
{
  public CountriesContext(DbContextOptions<CountriesContext> options)
    : base(options)
  {
  }

  public DbSet<Countries> CountriesList { get; set; } = null!;
}