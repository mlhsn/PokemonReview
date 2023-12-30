namespace WebApi.Models;

public class Country
{
    public uint Id { get; set; }
    
    public string Name { get; set; } = String.Empty;

    public ICollection<Owner> Owners { get; set; }
}