using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }

    [Display(Name = "Date Released")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
    [Range(10, 1000, ErrorMessage = "The price should be between 10 and 1000")]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}