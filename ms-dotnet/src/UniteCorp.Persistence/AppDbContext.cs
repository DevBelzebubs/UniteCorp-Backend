using Microsoft.EntityFrameworkCore;

namespace UniteCorp.Persistence;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options);
