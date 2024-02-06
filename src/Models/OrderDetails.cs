using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdventureTIme.Models;

[Table("SalesOrderDetail", Schema = "SalesLT")]
public class OrderDetails
{
    [Key]
    [Column("SalesOrderDetailID")]
    public int SalesOrderDetailId { get; set; }
    

    [Column("SalesOrderID")]
    public int SalesOrderId { get; set; }

    
    public Order? Order { get; set; }
    
    public int OrderQty { get; set; }
    
    [ForeignKey(nameof(ProductId))]
    public int ProductId { get; set; }
    
    public Product? Product { get; set; }
    
    public decimal UnitPrice { get; set; }
    
    public decimal UnitPriceDiscount { get; set; }
    
    public decimal LineTotal { get; set; }
}