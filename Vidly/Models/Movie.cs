using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Date of Release")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Date when Movie Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Number of Stock")]
        public int StockCount { get; set; }

        public Genre Genre { get; set; }
    }
}