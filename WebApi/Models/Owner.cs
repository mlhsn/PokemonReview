namespace WebApi.Models;

public class Owner
{
    public uint Id { get; set; }

    public string Name { get; set; } = String.Empty;

    public string Gym { get; set; } = String.Empty;

    public Country Country { get; set; }

    public ICollection<PokemonOwner> PokemonOwners { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }
}