using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureTIme.Models;


[Table("Customer", Schema = "SalesLT")]
public class Customer
{
   
   [Key]
   public int CustomerId { get; set; }
   
   
   public string? Title {get; set; }
   
   [Required]
   public string FirstName { get; set; }
   
   [Required]
   public string LastName { get; set; }
   
   public string? MiddleName { get; set; }
   
}