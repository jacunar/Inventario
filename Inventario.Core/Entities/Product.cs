namespace Inventario.Core.Entities; 
public class Product: EntityBase {
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal UnitPrice { get; set; }
    public int Stock { get; set; }
    public int MinStock { get; set; }
    public int CategoryId { get; set; }
    public int ProviderId { get; set; }
    public Category Category { get; set; }
    public Provider Provider { get; set; }
}