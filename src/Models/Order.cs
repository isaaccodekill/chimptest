using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdventureTIme.Models;

[Table("SalesOrderHeader", Schema = "SalesLT")]
public class Order
{
    [Key]
    public int SalesOrderId { get; set; }
    
    public DateTime OrderDate { get; set; }
    
    public DateTime DueDate { get; set; }
    
    public DateTime? ShipDate { get; set; }
    
    public string purchaseOrderNumber { get; set; }
    
    [ForeignKey(nameof(CustomerId))]
    public int CustomerId { get; set; }
    
    public Customer? Customer { get; set; }
    
    public byte Status { get; set; }
    
    public string AccountNumber { get; set; }
    
    [ForeignKey(nameof(ShipToAddressId))]
    public int? ShipToAddressId { get; set; }
    
    
    public Address? ShipToAddress { get; set; }
    
    [ForeignKey(nameof(BillToAddressId))]
    public int? BillToAddressId { get; set; }
    
    public Address? BillToAddress { get; set; }
    
    public string ShipMethod { get; set; }
    
    public string? CreditCardApprovalCode { get; set; }
    
    public decimal SubTotal { get; set; }
    
    public decimal TaxAmt { get; set; }
    
    public decimal Freight { get; set; }

    public decimal TotalDue { get; set; }
    
    public string? Comment { get; set; }
    
    
    public ICollection<OrderDetails> SalesOrderDetail { get; set; }
    
    

    
    
    
    
}