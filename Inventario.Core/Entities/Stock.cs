namespace Inventario.Core.Entities; 
public class Stock: EntityBase {
    public int ProductId { get; set; }
    public int IncomingQuantity { get; set; }
    public string Description { get; set; }
    public int UserId { get; set; }
    public DateTime IncomingDate { get; set; }
    public Product Product { get; set; }

}