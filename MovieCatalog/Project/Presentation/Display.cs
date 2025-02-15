using System;
using System.Collections.Generic;
using System.Text;
using Project.Data.Model;
using Project.Business;
using System.Linq;

namespace Project.Presentation
{
    public class Display
    {
        private int closeOperationId = 6;

        private ProjectBusiness projectBusiness = new ProjectBusiness();

        /// <summary>
        /// Constructor
        /// </summary>
        public Display()
        {
            Input();
        }

        /// <summary>
        /// Menu UI
        /// </summary>
        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "MENU" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. Add new entry");
            Console.WriteLine("2. Update entry");
            Console.WriteLine("3. Fetch entry by ID");
            Console.WriteLine("4. Delete entry by ID");
            Console.WriteLine("5. List all entries");
            Console.WriteLine("6. Exit");
        }

        /// <summary>
        /// User Input
        /// </summary>
        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Update();
                        break;
                    case 3:
                        Fetch();
                        break;
                    case 4:
                        Delete();
                        break;
                    case 5:
                        ListAll();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }

        /// <summary>
        /// US for Deletion
        /// </summary>
        
            
           
        private void Delete()
        {
            Console.WriteLine("Enter 'a' for actor, 'm' for movie, 'g' for genre or 'd' for director");
            string inputLine = Console.ReadLine();
            int id;
            if(inputLine.ToLower() == "a")
            {
                Console.WriteLine("Enter ID to delete: ");
                id = int.Parse(Console.ReadLine());
                projectBusiness.DeleteActor(id);
                Console.WriteLine("Done");
            }
            if (inputLine.ToLower() == "m")
            {
                Console.WriteLine("Enter ID to delete: ");
                id = int.Parse(Console.ReadLine());
                projectBusiness.DeleteMovie(id);
                Console.WriteLine("Done");
            }
            if (inputLine.ToLower() == "g")
            {
                Console.WriteLine("Enter ID to delete: ");
                id = int.Parse(Console.ReadLine());
                projectBusiness.DeleteGenre(id);
                Console.WriteLine("Done");
            }
            if (inputLine.ToLower() == "d")
            {
                Console.WriteLine("Enter ID to delete: ");
                id = int.Parse(Console.ReadLine());
                projectBusiness.DeleteDirector(id);
                Console.WriteLine("Done");
            }

        }

        /// <summary>
        /// UI for getting records from the database
        /// </summary>
        private void Fetch()
        {
            Console.WriteLine("Enter 'a' for actor, 'm' for movie, 'g' for genre or 'd' for director");
            string inputLine = Console.ReadLine();
            int id;
            if (inputLine.ToLower() == "a")
            {
                Console.WriteLine("Enter ID to fetch: ");
                id = int.Parse(Console.ReadLine());
                Actor actor = projectBusiness.GetActor(id);
                if (actor != null)
                {
                    Console.WriteLine(new string('-', 40));
                    Console.WriteLine("ID: " + actor.ActorId);
                    Console.WriteLine("Name: " + actor.Actor_Name);
                    Console.WriteLine("Birthplace: " + actor.Birthplace);
                    Console.WriteLine("Age: " + actor.Age);
                    Console.WriteLine(new string('-', 40));
                }
                else
                {
                    Console.WriteLine("Actor not found");
                }
            }

            if (inputLine.ToLower() == "m")
            {
                Console.WriteLine("Enter ID to fetch: ");
                id = int.Parse(Console.ReadLine());
                Movie movie = projectBusiness.GetMovie(id);
                Genre genreName = projectBusiness.GetGenre(movie.Genre_Id);
                Actor actorName = projectBusiness.GetActor(movie.Actor_Id);
                Director directorName = projectBusiness.GetDirector(movie.Director_Id);
                if (movie != null)
                {
                    Console.WriteLine(new string('-', 40));
                    Console.WriteLine("ID: " + movie.MovieId);
                    Console.WriteLine("Name: " + movie.Movie_Name);
                    Console.WriteLine("Director: " + directorName.Director_Name);
                    Console.WriteLine("Year of production: " + movie.Year);
                    Console.WriteLine("Genre: " + genreName.Genre_Name);
                    Console.WriteLine("Star role: " + actorName.Actor_Name);
                    Console.WriteLine(new string('-', 40));
                }
                else
                {
                    Console.WriteLine("Movie not found");
                }
            }
            if (inputLine.ToLower() == "g")
            {
                Console.WriteLine("Enter ID to fetch: ");
                id = int.Parse(Console.ReadLine());
                Genre genre = projectBusiness.GetGenre(id);
                if (genre != null)
                {
                    Console.WriteLine(new string('-', 40));
                    Console.WriteLine("ID: " + genre.GenreId);
                    Console.WriteLine("Name: " + genre.Genre_Name);
                    Console.WriteLine(new string('-', 40));
                }
                else
                {
                    Console.WriteLine("Genre not found");
                }
            }
            if (inputLine.ToLower() == "d")
            {
                Console.WriteLine("Enter ID to fetch: ");
                id = int.Parse(Console.ReadLine());
                Director director = projectBusiness.GetDirector(id);
                if (director != null)
                {
                    Console.WriteLine(new string('-', 40));
                    Console.WriteLine("ID: " + director.DirectorId);
                    Console.WriteLine("Name: " + director.Director_Name);
                    Console.WriteLine("Birthplace: " + director.Birthplace);
                    Console.WriteLine("Age: " + director.Age);
                    Console.WriteLine(new string('-', 40));
                }
                else
                {
                    Console.WriteLine("Director not found");
                }
            }

        }

        /// <summary>
        /// UI dor updating records in the database.
        /// </summary>
        private void Update()
        {
            Console.WriteLine("Enter 'a' for actor, 'm' for movie, 'g' for genre or 'd' for director");
            string inputLine = Console.ReadLine();
            int id;
            if (inputLine.ToLower() == "a")
            {
                Console.WriteLine("Enter ID to update: ");
                id = int.Parse(Console.ReadLine());
                Actor actor = projectBusiness.GetActor(id);
                if(actor != null)
                {
                    Console.WriteLine("Enter Name: ");
                    actor.Actor_Name = Console.ReadLine();
                    Console.WriteLine("Enter Birthplace: ");
                    actor.Birthplace = Console.ReadLine();
                    Console.WriteLine("Enter Age: ");
                    actor.Age = int.Parse(Console.ReadLine());
                    projectBusiness.UpdateActor(actor);
                }
                else
                {
                    Console.WriteLine("Actor not found");
                }
            }
            if (inputLine.ToLower() == "d")
            {
                Console.WriteLine("Enter ID to update: ");
                id = int.Parse(Console.ReadLine());
                Director director = projectBusiness.GetDirector(id);
                if (director != null)
                {
                    Console.WriteLine("Enter Name: ");
                    director.Director_Name = Console.ReadLine();
                    Console.WriteLine("Enter Birthplace: ");
                    director.Birthplace = Console.ReadLine();
                    Console.WriteLine("Enter Age: ");
                    director.Age = int.Parse(Console.ReadLine());
                    projectBusiness.UpdateDirector(director);
                }
                else
                {
                    Console.WriteLine("Director not found");
                }
            }
            if (inputLine.ToLower() == "m")
            {
                Console.WriteLine("Enter ID to update: ");
                id = int.Parse(Console.ReadLine());
                Movie movie = projectBusiness.GetMovie(id);
                if(movie != null)
                {
                    Console.WriteLine("Enter Name: ");
                    movie.Movie_Name = Console.ReadLine();
                    Console.WriteLine("Enter director_id: ");
                    movie.Director_Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Year of production: ");
                    movie.Year = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter genre id: ");
                    movie.Genre_Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter actor id: ");
                    movie.Actor_Id = int.Parse(Console.ReadLine());
                    projectBusiness.UpdateMovie(movie);
                }
                else
                {
                    Console.WriteLine("Movie could not be found");
                }
            }

            if(inputLine.ToLower() == "g")
            {
                Console.WriteLine("Enter ID to update: ");
                id = int.Parse(Console.ReadLine());
                Genre genre = projectBusiness.GetGenre(id);
                if (genre != null)
                {
                    Console.WriteLine("Enter Name: ");
                    genre.Genre_Name = Console.ReadLine();
                    projectBusiness.UpdateGenre(genre);
                }
                else
                {
                    Console.WriteLine("Genre could not be found");
                }
            }
        }


        /// <summary>
        /// UI for adding records to the database.
        /// </summary>

        private void Add()
        {
            Movie movie = new Movie();
            Actor actor = new Actor();
            Genre genre = new Genre();
            Director director = new Director();

            Console.WriteLine("Enter 'a' for actor, 'm' for movie, 'g' for genre or 'd' for director");
            string inputLine = Console.ReadLine();
            if (inputLine.ToLower() == "a")
            {
                Console.WriteLine("Enter Name: ");
                actor.Actor_Name = Console.ReadLine();
                Console.WriteLine("Enter Birthplace: ");
                actor.Birthplace = Console.ReadLine();
                Console.WriteLine("Enter Age: ");
                actor.Age = int.Parse(Console.ReadLine());
                projectBusiness.AddActor(actor);
            }
            if (inputLine.ToLower() == "d")
            {
                Console.WriteLine("Enter Name: ");
                director.Director_Name = Console.ReadLine();
                Console.WriteLine("Enter Birthplace: ");
                director.Birthplace = Console.ReadLine();
                Console.WriteLine("Enter Age: ");
                director.Age = int.Parse(Console.ReadLine());
                projectBusiness.AddDirector(director);
            }
            if (inputLine.ToLower() == "m")
            {
                Console.WriteLine("Enter Name: ");
                movie.Movie_Name = Console.ReadLine();
                Console.WriteLine("Enter Director id: ");
                movie.Director_Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Year of production: ");
                movie.Year = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Genre id: ");
                movie.Genre_Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Actor id: ");
                movie.Actor_Id = int.Parse(Console.ReadLine());
                projectBusiness.AddMovie(movie);
            }
            if (inputLine.ToLower() == "g")
            {
                Console.WriteLine("Enter Name: ");
                genre.Genre_Name = Console.ReadLine();
                projectBusiness.AddGenre(genre);
            }

        }

        /// <summary>
        /// UI to list all the products.
        /// </summary>



        private void ListAll()
        {           
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "MOVIES" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var movie = projectBusiness.GetAllMovies();
            foreach (var item in movie)
            {
                Genre genreName = projectBusiness.GetGenre(item.Genre_Id);
                Actor actorName = projectBusiness.GetActor(item.Actor_Id);
                Director directorName = projectBusiness.GetDirector(item.Director_Id);
                Console.WriteLine("ID: {0}", item.MovieId);
                Console.WriteLine("Name: {0}", item.Movie_Name);
                Console.WriteLine("Director: {0}", directorName.Director_Name);
                Console.WriteLine("Year of production: {0}", item.Year);
                Console.WriteLine("Genre: {0}", genreName.Genre_Name);
                Console.WriteLine("Starring actor: {0}", actorName.Actor_Name); 
            }

            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "ACTORS" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var actor = projectBusiness.GetAllActors();
            foreach (var item in actor)
            {
                Console.WriteLine("ID: {0}", item.ActorId);
                Console.WriteLine("Name: {0}", item.Actor_Name);            
                Console.WriteLine("Birthplace: {0}", item.Birthplace);
                Console.WriteLine("Age: {0}", item.Age);                
            }

            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "DIRECTORS" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var director = projectBusiness.GetAllDirectors();
            foreach (var item in director)
            {
                Console.WriteLine("ID: {0}", item.DirectorId);
                Console.WriteLine("Name: {0}", item.Director_Name);
                Console.WriteLine("Birthplace: {0}", item.Birthplace);
                Console.WriteLine("Age: {0}", item.Age);
            }

            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "GENRES" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var genre = projectBusiness.GetAllGenres();
            foreach (var item in genre)
            {
                Console.WriteLine("ID: {0}", item.GenreId);
                Console.WriteLine("Name: {0}", item.Genre_Name);
            }
        }
    }
}
