namespace CRUDWithCleanArchitectureAndSolid.Application.Dtos.Products;

public record UpdateProductDto(
    string Name,
    decimal Price,
    int Stock
);
