using VestigeApp.Models;

namespace VestigeApp.Services;

/// <summary>In-memory store (front end only). Seed entries are SAMPLE data: replace before submitting.</summary>
public class ReviewService
{
    public static readonly string[] Tours =
    {
        "Old Town Walking Tour",
        "Landmarks & Stories Tour",
        "Heritage Food Trail",
    };

    private readonly List<Review> _reviews = new()
    {
        new() { Author = "Sample Guest A", Tour = Tours[0], Rating = 5, Comment = "Sample review: replace with a real guest comment.", CreatedAt = DateTime.Now.AddDays(-6) },
        new() { Author = "Sample Guest B", Tour = Tours[2], Rating = 4, Comment = "Sample review: replace with a real guest comment.", CreatedAt = DateTime.Now.AddDays(-2) },
    };

    public IReadOnlyList<Review> All => _reviews.OrderByDescending(r => r.CreatedAt).ToList();
    public double Average => _reviews.Count == 0 ? 0 : _reviews.Average(r => r.Rating);
    public void Add(Review review) => _reviews.Add(review);

    // Fixed: changed 'Reviews' to '_reviews' so it points to the correct private list
    public Dictionary<int, int> Distribution 
    {
        get
        {
            // Group reviews by rating and count them, defaulting to 0 for missing ratings
            return Enumerable.Range(1, 5).ToDictionary(
                star => star,
                star => _reviews.Count(r => r.Rating == star)
            );
        }
    }
}