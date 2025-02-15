using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Project.Data.Model;

namespace Project.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Director> Director { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=project;user=root;password=1234");
        }
    }
}
