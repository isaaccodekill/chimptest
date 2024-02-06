using AdventureTIme.Models;
using AdventureTIme.Models.DTO;

namespace AdventureTIme.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetProducts();
    
    Task<Product?> GetProduct(int id);
    
    Task<IEnumerable<Category>> GetCategories();
    
    Task<IEnumerable<Product>> GetProductsByCategory(int categoryId);
    
    Task<Product> AddProduct(CreateProductDto product);
    
    Task<Category> AddCategory(CreateCategory category);
    
    Task<Product> UpdateProduct(int id, UpdateProductDto product);
    
    Task<Product> DeleteProduct(int id);
    
    Task<Category> DeleteCategory(int id);
    
    
}