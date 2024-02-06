using AdventureTIme.Models;
using AdventureTIme.Models.DTO;
using AdventureTIme.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdventureTIme.Controllers;

[Route("api/products")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;
    public ProductController(IProductService productService)
    {
        _productService = productService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        var products = await _productService.GetProducts();
        return Ok(products);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetProduct(int id)
    {
        var product = await _productService.GetProduct(id);
        if (product != null)
        {
            return Ok(product);
        }
        else
        {
            return NotFound("Product not found.");
        }
    }
    
    [HttpGet("/category")]
    public async Task<IActionResult> GetCategories()
    {
        var categories = await _productService.GetCategories();
        return Ok(categories);
    }
    
    [HttpGet("category/{id}")]
    public async Task<IActionResult> GetProductsByCategory(int categoryId)
    {
        var products = await _productService.GetProductsByCategory(categoryId);
        if (products != null)
        {
            return Ok(products);
        }
        else
        {
            return NotFound("Products not found.");
        }
    }
    
    [HttpPost]
    public async Task<IActionResult> AddProduct([FromBody] CreateProductDto product)
    {
        var newProduct = await _productService.AddProduct(product);
        return CreatedAtAction(nameof(GetProduct), new { id = newProduct.ProductId }, newProduct);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(int id, [FromBody] UpdateProductDto product)
    {
        var updatedProduct = await _productService.UpdateProduct(id, product);
        if (updatedProduct != null)
        {
            return Ok(updatedProduct);
        }
        else
        {
            return NotFound("Product not found.");
        }
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var deletedProduct = await _productService.DeleteProduct(id);
        if (deletedProduct != null)
        {
            return Ok(deletedProduct);
        }
        else
        {
            return NotFound("Product not found.");
        }
    }
    
    // create category
    [HttpPost("category")]
    public async Task<IActionResult> AddCategory([FromBody] CreateCategory category)
    {
        var newCategory = await _productService.AddCategory(category);
        return CreatedAtAction(nameof(GetCategories), new { id = newCategory.ProductCategoryId }, newCategory);
    }
    
    [HttpDelete("category/{id}")]
    public async Task<IActionResult> DeleteCategory(int id)
    {
        var deletedCategory = await _productService.DeleteCategory(id);
        if (deletedCategory != null)
        {
            return Ok(deletedCategory);
        }
        else
        {
            return NotFound("Category not found.");
        }
    }
    
    
}