namespace Ladesign.Models;

public class PriceModel
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public List<string>? Options { get; set; }
}
