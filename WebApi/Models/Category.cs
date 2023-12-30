namespace WebApi.Models;

public class Category
{
    public uint Id { get; set; }

    public string Name { get; set; } = String.Empty;

    public ICollection<PokemonCategory> PokemonCategories { get; set; }
}