using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureTIme.Models;


[Table("ProductCategory", Schema = "SalesLT")]
public class Category
{
    [Key]
    public int ProductCategoryId { get; set; }
    
    public string? Name { get; set; }
    
    [ForeignKey("Category")]
    public int? ParentProductCategoryId { get; set; }
    
    public Category? ParentProductCategory { get; set; }
    
    
}