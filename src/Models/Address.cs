using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureTIme.Models;

[Table("Address", Schema = "SalesLT")]
public class Address
{
    [Key]
    public int AddressId { get; set; }
    
    public string AddressLine1 { get; set; }
    
    public string? AddressLine2 { get; set; }
    
    public string City { get; set; }
    
    public string StateProvince { get; set; }
    
    public string CountryRegion { get; set; }
    
    public string PostalCode { get; set; }

}