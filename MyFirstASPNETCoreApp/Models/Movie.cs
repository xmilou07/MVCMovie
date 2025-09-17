using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstASPNETCoreApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [Display(Name = "Release Date")] // make sure the label looks better in the UI
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")] // needed so that it can make the correct currency type in the database
        public decimal Price { get; set; }
    }
}
