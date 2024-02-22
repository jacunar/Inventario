namespace Inventario.Core.Entities; 
public abstract class EntityBase {
    public Guid Id { get; set; }
    public bool Active { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime ModificationDate { get; set; }
}