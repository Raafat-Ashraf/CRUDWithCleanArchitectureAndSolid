namespace CRUDWithCleanArchitectureAndSolid.Application.Dtos.Products;

public record ProductDto(
    int Id,
    string Name,
    decimal Price,
    int Stock
);
