using CRUDWithCleanArchitectureAndSolid.Domain.Entities;
using CRUDWithCleanArchitectureAndSolid.Domain.Interfaces.Products;
using CRUDWithCleanArchitectureAndSolid.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CRUDWithCleanArchitectureAndSolid.Infrastructure.Implementations;

public class ProductRepository(ApplicationDbContext context) : IProductRepository
{
    private readonly ApplicationDbContext _context = context;

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _context.Products.AsNoTracking().ToListAsync();
    }

    public async Task<Product?> GetByIdAsync(int id)
    {
        var product = await _context.Products.FindAsync(id);

        return product;
    }

    public async Task<Product> AddAsync(Product product)
    {
         await _context.AddAsync(product);
         await _context.SaveChangesAsync();

         return product;
    }

    public async Task UpdateAsync(Product product)
    {
        _context.Update(product);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product is not null)
            _context.Products.Remove(product);
    }
}
