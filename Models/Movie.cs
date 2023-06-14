using System.Buffers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Price { get; set; }
        public string? Genre { get; set; }
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Display(Name = "Date Occurred")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email is invalid")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Phone address required")]
        //[Phone(ErrorMessage = "Invalid Contact Number")]
        public int Contact { get; set; }
        public string? Location { get; set; }
        [Display(Name = "Fault Category")]
        public Category FaultCategory { get; set; }
        [Display(Name = "Fault Description")]
        public string? FaultDescription { get; set; }
    }

    public enum Category {
        Mechanical,
        Plumbing,
        Electrical,
        AirConditioning,
        Building,
        Painting
    }
}