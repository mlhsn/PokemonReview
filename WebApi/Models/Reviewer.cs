namespace WebApi.Models;

public class Reviewer
{
    public uint Id { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }

    public ICollection<Review> Reviews { get; set; }
}