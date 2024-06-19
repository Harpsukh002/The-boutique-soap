using System.ComponentModel.DataAnnotations;

namespace The_boutique_soap.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public string? Scent { get; set; }
    public string? Genre { get; set; }
    public decimal Price { get; set; }
}