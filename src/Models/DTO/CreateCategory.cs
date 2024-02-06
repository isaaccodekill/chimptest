namespace AdventureTIme.Models.DTO;

public class CreateCategory
{
    public string Name { get; set; }
    public int? ParentCategoryId { get; set; }
}