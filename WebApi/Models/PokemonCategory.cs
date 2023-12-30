namespace WebApi.Models;

public class PokemonCategory
{
    public uint PokemonId { get; set; }

    public uint CategoryId { get; set; }

    public Pokemon Pokemon { get; set; }
    
    public Category Category { get; set; }
}