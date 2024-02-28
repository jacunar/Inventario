namespace Inventario.Core.Entities; 
public class Provider: EntityBase {
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}