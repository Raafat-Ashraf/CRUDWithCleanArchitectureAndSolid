using CRUDWithCleanArchitectureAndSolid.Application.Dtos.Products;

namespace CRUDWithCleanArchitectureAndSolid.Application.UseCaseInterfaces;

public interface IProductService
{
    Task<IEnumerable<ProductDto>> GetAllAsync();
    Task<ProductDto?> GetByIdAsync(int id);
    Task<ProductDto> AddAsync(CreateProductDto productDto);
    Task UpdateAsync(int id ,UpdateProductDto productDto);
    Task DeleteAsync(int id);
}
