using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Model
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Genre_Name { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
