using CRUDWithCleanArchitectureAndSolid.Application.Dtos.Products;
using CRUDWithCleanArchitectureAndSolid.Application.MappingInterfaces;
using CRUDWithCleanArchitectureAndSolid.Domain.Entities;

namespace CRUDWithCleanArchitectureAndSolid.Application.MappingImplementations;

public class ProductMapper : IProductMapper
{
    public ProductDto MapToDto(Product product)
        => new ProductDto(product.Id, product.Name, product.Price, product.Stock);

    public Product MapToEntity(CreateProductDto createDto)
        => new Product { Name = createDto.Name, Price = createDto.Price, Stock = createDto.Stock };

    public Product MapToEntity(UpdateProductDto updateDto)
        => new Product { Name = updateDto.Name, Price = updateDto.Price, Stock = updateDto.Stock };

}
