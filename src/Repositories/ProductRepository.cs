using AdventureTime.Models;
using AdventureTIme.Models;
using AdventureTIme.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace AdventureTIme.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AdventureTimeDbContext _context;

    public ProductRepository(AdventureTimeDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetProducts()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product?> GetProduct(int id)
    {
        return await _context.Products
            .Where(p => p.ProductId == id)
            .Include(p => p.ProductCategory)
            .FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Category>> GetCategories()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task<IEnumerable<Product>> GetProductsByCategory(int categoryId)
    {
        return await _context.Products.Where(p => p.ProductCategoryId == categoryId).ToListAsync();
    }

    public async Task<Product> AddProduct(CreateProductDto product)
    {
        var newProduct = new Product
        {
            Name = product.Name,
            ProductNumber = product.ProductNumber,
            Color = product.Color,
            StandardCost = product.StandardCost,
            ListPrice = product.ListPrice,
            ProductCategoryId = product.ProductCategoryId
        };

        _context.Products.Add(newProduct);
        await _context.SaveChangesAsync();
        return newProduct;
    }

    public async Task<Category> AddCategory(CreateCategory category)
    {
        var newCategory = new Category
        {
            Name = category.Name,
            ParentProductCategoryId = category.ParentCategoryId
        };

        _context.Categories.Add(newCategory);
        await _context.SaveChangesAsync();
        return newCategory;
    }

    public async Task<Product> UpdateProduct(int id, UpdateProductDto product)
    {
        var existingProduct = await _context.Products.FindAsync(id);
        if (existingProduct == null)
        {
            throw new ArgumentException("Product not found");
        }

        existingProduct.Name = product.Name;
        existingProduct.ProductNumber = product.ProductNumber;
        existingProduct.Color = product.Color;
        existingProduct.StandardCost = product.StandardCost;
        existingProduct.ListPrice = product.ListPrice;
        existingProduct.ProductCategoryId = product.ProductCategoryId;

        await _context.SaveChangesAsync();
        return existingProduct;
    }

    public async Task<Product> DeleteProduct(int id)
    {
        var existingProduct = await _context.Products.FindAsync(id);
        if (existingProduct == null)
        {
            throw new ArgumentException("Product not found");
        }

        _context.Products.Remove(existingProduct);
        await _context.SaveChangesAsync();
        return existingProduct;
    }

    public async Task<Category> DeleteCategory(int id)
    {
        var existingCategory = await _context.Categories.FindAsync(id);
        if (existingCategory == null)
        {
            throw new ArgumentException("Category not found");
        }
        _context.Categories.Remove(existingCategory);
        await _context.SaveChangesAsync();
        return existingCategory;
    }
}