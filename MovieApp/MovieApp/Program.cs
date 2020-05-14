



using System;
using MovieApp.Entities;
using MovieApp.Helpers;
using System.Collections.Generic;
using System.Linq;


namespace MovieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = MovieHelper.GetAllActionMovies();
            Console.ForegroundColor = ConsoleColor.Red;

            // Find all movies that their titles starts with "L"

            // LAMBDA
            var moviesTitle = movies.Where(movie => movie.Title.StartsWith('L')).ToList();
            moviesTitle.ForEach(movie => Console.WriteLine(movie.Title));

            // QUERY
            var moviesTitleQ = (from movie in movies where movie.Title.StartsWith('L') select movie.Title).ToList();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------------------");

            // Find a NUMBER of movies that have rating higher than 7.5

            // LAMBDA
            var numberMoviesRating = movies.Where(movie => movie.Rating > 7.5).ToList().Count;
            //Console.WriteLine(numberMoviesRating);

            // QUERY
            var numberMoviesRatingQ = (from movie in movies where movie.Rating > 7.5 select movie).ToList().Count;
            Console.WriteLine(numberMoviesRating);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------------------------------------------");

            // Find all movies TITLES with year of production before 2005

            // LAMBDA
            var allMoviesTitles = movies.Where(movie => movie.Year < 2005).Select(movie => movie.Title).ToList();
            //allMoviesTitles.ForEach(movie => Console.WriteLine(movie));

            // QUERY
            var allMoviesTitlesQ = (from movie in movies where movie.Year > 2005 select movie.Title).ToList();
            allMoviesTitlesQ.ForEach(movie => Console.WriteLine(movie));

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------------------");

            // Find all movies TITLES and RATHING that have rating higher then 8.0

            // LAMBDA
            var allTitlesAndRathingHigher = movies.Where(movie => movie.Rating > 8.0).Select(movie => new { movie.Title, movie.Rating }).ToList();
            //allTitlesAndRathingHigher.ForEach(movie => Console.WriteLine(movie));

            // QUERY
            var allTitlesAndRathingHigherQ = (from movie in movies where movie.Rating > 8.0 select movie).Select(movie => new { movie.Title, movie.Rating }).ToList();
            allTitlesAndRathingHigherQ.ForEach(movie => Console.WriteLine(movie));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------------------------------------------");

            // Find first 5 movies that have duration time longer then 2 hours

            // LAMBDA
            var firstFiveMovies = movies.Where(movie => movie.Duration > 120).Take(5).ToList();
            //firstFiveMovies.ForEach(movie => Console.WriteLine(movie.Title));

            // QUERY
            var firstFiveMoviesQ = (from movie in movies where movie.Duration > 120 select movie).Take(5).ToList();
            firstFiveMoviesQ.ForEach(movie => Console.WriteLine(movie.Title));

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------------------");

            // Find last 3 movies TITLES and DURATION that have duration less then 2 hours

            // LAMBDA
            var lastThreeMovies = movies.Where(movie => movie.Duration < 120).Select(movie => new { movie.Title, movie.Duration }).TakeLast(3).ToList();
            //lastThreeMovies.ForEach(movie => Console.WriteLine(movie));

            // QUERY

            var lastThreeMoviesQ = (from movie in movies where movie.Duration < 120 select movie).Select(movie => new { movie.Title, movie.Duration }).TakeLast(3).ToList();
            lastThreeMoviesQ.ForEach(movie => Console.WriteLine(movie));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------------------------------------------");

            // Find all movies TITLES and RATHING and order them by DURATION(DESC) - no condition needed


            // LAMBDA
            var allTitlesRathingDesc = movies.OrderByDescending(movie => movie.Duration).Select(movie => new { movie.Title, movie.Rating }).ToList();
            //allTitlesRathingDesc.ForEach(movie => Console.WriteLine(movie));

            // QUERY
            var allTitlesRathingDescQ = (from movie in movies orderby movie.Duration descending select movie).Select(movie => new { movie.Title, movie.Rating }).ToList();
            allTitlesRathingDescQ.ForEach(movie => Console.WriteLine(movie));

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------------------");

            // Find all movies with TITLES that dosen't start with A and TITLES include more than 7 characters

            // LAMBDA
            var allMoviesStartAHaveSevenChar = movies.Where(movie => !movie.Title.StartsWith('A') && movie.Title.Length > 7).ToList();
            //allMoviesStartAHaveSevenChar.ForEach(movie => Console.WriteLine(movie.Title));

            // QUERY
            var allMoviesStartAHaveSevenCharQ = (from movie in movies where !movie.Title.StartsWith('A') && movie.Title.Length < 7 select movie).ToList();
            allMoviesStartAHaveSevenCharQ.ForEach(movie => Console.WriteLine(movie.Title));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------------------------------------------");

            // Find all movies RATINGS higher than 7.2, DURATIONS less then 1 hour and 50 min

            // LAMBDA
            var moviesRathingHigherThanSeven = movies.Where(movie => movie.Rating > 7.2 && movie.Duration < 110).Select(movie => movie.Title).ToList();
            //moviesRathingHigherThanSeven.ForEach(movie => Console.WriteLine(movie));

            // QUERY
            var moviesRathingHigherThanSevenQ = (from movie in movies where movie.Rating > 7.2 && movie.Duration < 110 select movie).ToList();
            moviesRathingHigherThanSevenQ.ForEach(movie => Console.WriteLine(movie.Title));

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------------------");

            // Find all movies TITLES and RATHINGS that have TITLES with less than 10 characters,DURATION longer than 2 hours, RATHING higher then 6.7 and order them by TITLE(ASC)

            // LAMBDA 
            var moviesTitlesLessTenChar = movies.Where(movie => movie.Title.Length < 10 && movie.Duration > 120).OrderBy(movie => movie.Title).Select(movie => new { movie.Title, movie.Rating }).ToList();
            //moviesTitlesLessTenChar.ForEach(movie => Console.WriteLine(movie));

            // QUERY
            var moviesTitlesLessTenCharQ = (from movie in movies where movie.Title.Length < 10 && movie.Duration > 120 orderby movie.Title select movie).Select(movie => new { movie.Title, movie.Rating }).ToList();
            moviesTitlesLessTenCharQ.ForEach(movie => Console.WriteLine(movie));

            Console.ReadLine();
        }




    }
}
