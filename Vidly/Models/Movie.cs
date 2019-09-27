using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public DateTime releaseDate { get; set; }
        [Required]
        public DateTime dateAdded { get; set; }
        [Required]
        public int numberInStock { get; set; }
        public Genre genre { get; set; }
        public int GenreId { get; set; }

    }
}