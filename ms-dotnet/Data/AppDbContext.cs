using Microsoft.EntityFrameworkCore;

namespace UniteCorp.MsDotnet.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options);