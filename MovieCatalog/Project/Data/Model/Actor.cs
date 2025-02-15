using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Model
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string Actor_Name { get; set; }
        public string Birthplace { get; set; }
        public int Age { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
