using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Model
{
    public class Director
    {
        public int DirectorId { get; set; }
        public string Director_Name { get; set; }
        public string Birthplace { get; set; }
        public int Age { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
