using AdventureTIme.Models;
using AdventureTIme.Models.DTO;
using AdventureTIme.Repositories;

namespace AdventureTIme.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    
    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    public async Task<IEnumerable<Product>> GetProducts()
    {
        return await _productRepository.GetProducts();
    }
    
    public async Task<Product?> GetProduct(int id)
    {
        return await _productRepository.GetProduct(id);
    }
    
    public async Task<IEnumerable<Category>> GetCategories()
    {
        return await _productRepository.GetCategories();
    }
    
    public async Task<IEnumerable<Product>> GetProductsByCategory(int categoryId)
    {
        return await _productRepository.GetProductsByCategory(categoryId);
    }
    
    public async Task<Product> AddProduct(CreateProductDto product)
    {
        return await _productRepository.AddProduct(product);
    }
    
    public async Task<Category> AddCategory(CreateCategory category)
    {
        return await _productRepository.AddCategory(category);
    }
    
    public async Task<Product> UpdateProduct(int id, UpdateProductDto product)
    {
        return await _productRepository.UpdateProduct(id, product);
    }
    
    public async Task<Product> DeleteProduct(int id)
    {
        return await _productRepository.DeleteProduct(id);
    }
    
    public async Task<Category> DeleteCategory(int id)
    {
        return await _productRepository.DeleteCategory(id);
    }
    




}