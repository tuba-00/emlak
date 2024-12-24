public class Estate
{
    public int Id { get; set; }
    public required string Category { get; set; } // "Satılık Arsa", "Kiralık Daire" gibi
    public required string Title { get; set; }
    public required string Description { get; set; }
    public decimal Price { get; set; }
    public required string ImageUrl { get; set; }
}
