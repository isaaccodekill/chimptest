using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdventureTIme.Models;


[Table("Product", Schema = "SalesLT")]
public class Product
{
    
    public int ProductId { get; set; }
   
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string ProductNumber { get; set; }
    
    public string? Color { get; set; }
    
    [Required]
    public decimal StandardCost { get; set; }

    [Required]
    public decimal ListPrice { get; set; }
    
    [ForeignKey("Category")]
    public int ProductCategoryId { get; set; }
    
    public Category ProductCategory { get; set; }
    
}