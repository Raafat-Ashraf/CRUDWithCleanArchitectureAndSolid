using CRUDWithCleanArchitectureAndSolid.Application.Dtos.Products;
using CRUDWithCleanArchitectureAndSolid.Application.UseCaseInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace CRUDWithCleanArchitectureAndSolid.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController(IProductService productService) : ControllerBase
{
    private readonly IProductService _productService = productService;

    [HttpGet()]
    public async Task<IActionResult> GetAllProducts()
    {
        var products = await _productService.GetAllAsync();

        return Ok(products);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetProductById(int id)
    {
        var product = await _productService.GetByIdAsync(id);

        return product == null ? NotFound() : Ok(product);
    }

    [HttpPost("")]
    public async Task<IActionResult> AddProduct([FromBody] CreateProductDto productDto)
    {
        var result = await _productService.AddAsync(productDto);

        return CreatedAtAction(nameof(GetProductById), new { id = result.Id }, result);
    }


    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateProduct(int id, [FromBody] UpdateProductDto productDto)
    {
        await _productService.UpdateAsync(id, productDto);

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        await _productService.DeleteAsync(id);

        return NoContent();
    }
}
