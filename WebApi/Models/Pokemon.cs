namespace WebApi.Models;

public class Pokemon
{
    public ulong Id { get; set; }
    
    public string Name { get; set; } = String.Empty;
    
    public DateTime BirthDay { get; set; }
    
    public ICollection<Review> Reviews { get; set; }

    public ICollection<PokemonOwner> PokemonOwners { get; set; }

    public ICollection<PokemonCategory> PokemonCategories { get; set; }
}
