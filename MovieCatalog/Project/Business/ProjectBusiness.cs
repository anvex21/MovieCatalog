using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.Data;
using Project.Data.Model;


namespace Project.Business
{
    class ProjectBusiness
    {
        private MovieContext projectContext;

        /// <summary>
        /// Get all movies from the database
        /// </summary>

        public List<Movie> GetAllMovies()
        {
            using (projectContext = new MovieContext())
            {
                return projectContext.Movie.ToList();
            }
        }
        /// <summary>
        /// Get all actors from the database
        /// </summary>

        public List<Actor> GetAllActors()
        {
            using (projectContext = new MovieContext())
            {
                return projectContext.Actor.ToList();
            }
        }

        /// <summary>
        /// Get all genres from the database
        /// </summary>

        public List<Genre> GetAllGenres()
        {
            using (projectContext = new MovieContext())
            {
                return projectContext.Genre.ToList();
            }
        }

        /// <summary>
        /// Get all directors from the database
        /// </summary>
        public List<Director> GetAllDirectors()
        {
            using (projectContext = new MovieContext())
            {
                return projectContext.Director.ToList();
            }
        }

        /// <summary>
        /// Get a single movie from the database by id
        /// </summary>


        public Movie GetMovie(int id)
        {
            using (projectContext = new MovieContext())
            {
                return projectContext.Movie.Find(id);
            }
        }
        /// <summary>
        /// Get a single actor from the database by id
        /// </summary>


        public Actor GetActor(int id)
        {
            using (projectContext = new MovieContext())
            {
                return projectContext.Actor.Find(id);
            }
        }

        /// <summary>
        /// Get a single genre from the database by id
        /// </summary>


        public Genre GetGenre(int id)
        {
            using (projectContext = new MovieContext())
            {
                return projectContext.Genre.Find(id);
            }
        }

        /// <summary>
        /// Get a single director from the database by id
        /// </summary>

        public Director GetDirector(int id)
        {
            using (projectContext = new MovieContext())
            {
                return projectContext.Director.Find(id);
            }
        }

        /// <summary>
        /// Add a movie to the database
        /// </summary>

        public void AddMovie(Movie movie)
        {
            using (projectContext = new MovieContext())
            {
                projectContext.Movie.Add(movie);
                projectContext.SaveChanges();
            }
        }

        /// <summary>
        /// Add an actor to the database
        /// </summary>

        public void AddActor(Actor actor)
        {
            using (projectContext = new MovieContext())
            {
                projectContext.Actor.Add(actor);
                projectContext.SaveChanges();
            }
        }


        /// <summary>
        /// Add a movie to the database
        /// </summary>

        public void AddGenre(Genre genre)
        {
            using (projectContext = new MovieContext())
            {
                projectContext.Genre.Add(genre);
                projectContext.SaveChanges();
            }
        }

        /// <summary>
        /// Add an director to the database
        /// </summary>

        public void AddDirector(Director director)
        {
            using (projectContext = new MovieContext())
            {
                projectContext.Director.Add(director);
                projectContext.SaveChanges();
            }
        }



        /// <summary>
        /// Update a single movie in the database by id
        /// </summary>

        public void UpdateMovie(Movie movie)
        {
            using (projectContext = new MovieContext())
            {
                var item = projectContext.Movie.Find(movie.MovieId);
                if (item != null)
                {
                    projectContext.Entry(item).CurrentValues.SetValues(movie);
                    projectContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Update a single actor in the database by id
        /// </summary>

        public void UpdateActor(Actor actor)
        {
            using (projectContext = new MovieContext())
            {
                var item = projectContext.Actor.Find(actor.ActorId);
                if (item != null)
                {
                    projectContext.Entry(item).CurrentValues.SetValues(actor);
                    projectContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Update a single genre in the database by id
        /// </summary>

        public void UpdateGenre(Genre genre)
        {
            using (projectContext = new MovieContext())
            {
                var item = projectContext.Genre.Find(genre.GenreId);
                if (item != null)
                {
                    projectContext.Entry(item).CurrentValues.SetValues(genre);
                    projectContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Update a single director in the database by id
        /// </summary>

        public void UpdateDirector(Director director)
        {
            using (projectContext = new MovieContext())
            {
                var item = projectContext.Director.Find(director.DirectorId);
                if (item != null)
                {
                    projectContext.Entry(item).CurrentValues.SetValues(director);
                    projectContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Delete a movie from the database by id
        /// </summary>

        public void DeleteMovie(int id)
        {
            using (projectContext = new MovieContext())
            {
                var product = projectContext.Movie.Find(id);
                if (product != null)
                {
                    projectContext.Movie.Remove(product);
                    projectContext.SaveChanges();
                }
            }
        }
        /// <summary>
        /// Delete an actor from the database by id
        /// </summary>

        public void DeleteActor(int id)
        {
            using (projectContext = new MovieContext())
            {
                var product = projectContext.Actor.Find(id);
                if (product != null)
                {
                    projectContext.Actor.Remove(product);
                    projectContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Delete a genre from the database by id
        /// </summary>

        public void DeleteGenre(int id)
        {
            using (projectContext = new MovieContext())
            {
                var product = projectContext.Genre.Find(id);
                if (product != null)
                {
                    projectContext.Genre.Remove(product);
                    projectContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Delete a director from the database by id
        /// </summary>

        public void DeleteDirector(int id)
        {
            using (projectContext = new MovieContext())
            {
                var product = projectContext.Director.Find(id);
                if (product != null)
                {
                    projectContext.Director.Remove(product);
                    projectContext.SaveChanges();
                }
            }
        }


    }
}
