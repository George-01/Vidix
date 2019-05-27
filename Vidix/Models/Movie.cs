using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidix.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public DateTime DatetAdded { get; set; }

        [Required]
        [Range(1,20)]
        public byte NumberInStock { get; set; }



    }
}