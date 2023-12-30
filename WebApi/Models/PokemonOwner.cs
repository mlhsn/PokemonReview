namespace WebApi.Models;

public class PokemonOwner
{
    public uint PokemonId { get; set; }

    public uint OwnerId { get; set; }

    public Pokemon Pokemon { get; set; }

    public Owner Owner { get; set; }
}