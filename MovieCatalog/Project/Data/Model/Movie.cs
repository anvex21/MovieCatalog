using System;
using System.Collections.Generic;
using System.Text;
using Project.Data.Model;

namespace Project.Data.Model
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Movie_Name { get; set; }
        public int Director_Id { get; set; }
        public int Actor_Id { get; set; }
        public int Year { get; set; }
        public int Genre_Id { get; set; }
        public Genre Genre { get; set; }
        public Actor Actor { get; set; }
        public Director Director { get; set; } 

    }
}
