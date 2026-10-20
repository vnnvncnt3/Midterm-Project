namespace VestigeApp.Models;

public class Review
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Author { get; set; } = "";
    public string Tour { get; set; } = "";
    public int Rating { get; set; }
    public string Comment { get; set; } = "";
    public DateTime CreatedAt { get; init; } = DateTime.Now;
}
