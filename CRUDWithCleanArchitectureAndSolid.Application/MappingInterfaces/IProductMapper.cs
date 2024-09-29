using CRUDWithCleanArchitectureAndSolid.Application.Dtos.Products;
using CRUDWithCleanArchitectureAndSolid.Domain.Entities;

namespace CRUDWithCleanArchitectureAndSolid.Application.MappingInterfaces;

public interface IProductMapper
{
    ProductDto MapToDto(Product product);
    Product MapToEntity(CreateProductDto createDto);
    Product MapToEntity(UpdateProductDto updateDto);
}
