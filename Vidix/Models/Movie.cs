using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidix.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Genre Genre { get; set; }

        public byte GenreId { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DatetAdded { get; set; }

        public byte NumberInStock { get; set; }

    }
}