using CRUDWithCleanArchitectureAndSolid.Application.Dtos.Products;
using CRUDWithCleanArchitectureAndSolid.Application.MappingInterfaces;
using CRUDWithCleanArchitectureAndSolid.Application.UseCaseInterfaces;
using CRUDWithCleanArchitectureAndSolid.Domain.Interfaces.Products;

namespace CRUDWithCleanArchitectureAndSolid.Application.UseCaseImplementations;

public class ProductService(IProductRepository productRepository , IProductMapper productMapper) : IProductService
{
    private readonly IProductRepository _productRepository = productRepository;
    private readonly IProductMapper _productMapper = productMapper;


    public async Task<IEnumerable<ProductDto>> GetAllAsync()
    {
        var products = await _productRepository.GetAllAsync();

        return products.Select(_productMapper.MapToDto).ToList();
    }

    public async Task<ProductDto?> GetByIdAsync(int id)
    {
        var product = await _productRepository.GetByIdAsync(id);

        return product == null ? null : _productMapper.MapToDto(product);
    }

    public async Task<ProductDto> AddAsync(CreateProductDto createProductDto)
    {
        var product =  await _productRepository.AddAsync(_productMapper.MapToEntity(createProductDto));

        return _productMapper.MapToDto(product);
    }

    public async Task UpdateAsync(int id , UpdateProductDto updateProductDto)
    {
        var product = await _productRepository.GetByIdAsync(id);

        if (product == null)
            throw new Exception("Product not found");

        await _productRepository.UpdateAsync(_productMapper.MapToEntity(updateProductDto));
    }

    public async Task DeleteAsync(int id)
    {
        await _productRepository.DeleteAsync(id);
    }
}
