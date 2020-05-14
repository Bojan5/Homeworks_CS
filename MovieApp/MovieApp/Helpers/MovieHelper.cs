using MovieApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Helpers
{
    public class MovieHelper
    {
        public static List<Movie>GetAllActionMovies()
        {
            return new List<Movie>()
            {
                new Movie() {Title = "Gladiator", Year = 2000, Rating = 8.5f, Duration = 155},
                new Movie() {Title = "Avengers", Year = 2009, Rating = 8.4f, Duration = 181},
                new Movie() {Title = "Iron Man", Year = 2008, Rating = 7.9f, Duration = 126},
                new Movie() {Title = "The Dark Knight", Year = 2008, Rating = 9.0f, Duration = 152},
                new Movie() {Title = "Godfather", Year = 1972, Rating = 9.1f, Duration = 175},
                new Movie() {Title = "The Gentlmen", Year = 2019, Rating = 8.0f, Duration = 113},
                new Movie() {Title = "Fast and Furios", Year = 2019, Rating = 6.5f, Duration = 137},
                new Movie() {Title = "Mad Max", Year = 1979, Rating = 6.9f, Duration = 91},
                new Movie() {Title = "Casablanca", Year = 1942, Rating = 8.5f, Duration = 102},
                new Movie() {Title = "Back to the Future", Year = 1985, Rating = 8.5f, Duration = 116},
                new Movie() {Title = "Logan", Year = 2017, Rating = 8.1f, Duration = 137},
            };
        }
    }
}
