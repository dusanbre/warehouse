namespace Warehouse.Models;

public class Warehouse: BaseModel
{
    public string Name { get; set; }
    public string? Desctiption { get; set; }
    public string? Address { get; set; }
}