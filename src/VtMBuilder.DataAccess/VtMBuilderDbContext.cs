using Microsoft.EntityFrameworkCore;

namespace VtMBuilder.DataAccess;

public class VtMBuilderDbContext : DbContext
{
  public VtMBuilderDbContext(DbContextOptions<VtMBuilderDbContext> options) : base(options)
  {
    
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
  }
}