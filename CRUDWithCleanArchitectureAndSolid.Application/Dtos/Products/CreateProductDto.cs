namespace CRUDWithCleanArchitectureAndSolid.Application.Dtos.Products;

public record CreateProductDto(
    string Name,
    decimal Price,
    int Stock
);
