namespace AdventureTIme.Models.DTO;

public class CreateProductDto
{
    public string Name { get; set; }
    public string ProductNumber { get; set; }
    public string Color { get; set; }
    public decimal StandardCost { get; set; }
    public decimal ListPrice { get; set; }
    public int ProductCategoryId { get; set; }
}

