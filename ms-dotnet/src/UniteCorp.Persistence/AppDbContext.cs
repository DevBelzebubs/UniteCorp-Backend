using Microsoft.EntityFrameworkCore;
using UniteCorp.Features;

namespace UniteCorp.Persistence;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.ApplyConfigurationsFromAssembly(typeof(FeatureAssemblyMarker).Assembly);
	}
}
