using CRUDWithCleanArchitectureAndSolid.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUDWithCleanArchitectureAndSolid.Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; init; }


}
