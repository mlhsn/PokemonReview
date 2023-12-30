namespace WebApi.Models;

public class Review
{
    public uint Id { get; set; } 
    
    public string Title { get; set; } = String.Empty;
    
    public string Text { get; set; } = String.Empty;

    public Reviewer Reviewer { get; set; }

    public Pokemon Pokemon { get; set; }
}