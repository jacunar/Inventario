namespace Inventario.Core.Entities; 
public class Sales: EntityBase {
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public DateTime SalesDate { get; set; }
    public int UserId { get; set; }
    public string Description { get; set; }
    public Product Product { get; set; }
}