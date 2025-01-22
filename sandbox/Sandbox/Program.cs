using System;



class Program
{
    static void Main(string[] args)
    {
        Movie favoritMovie = new Movie();
        favoritMovie._title = "Star wars";
        favoritMovie._year = 1997;
        favoritMovie._runtime = 150;
        favoritMovie._rating = "Pg";

        Movie otherMovie = new Movie();
        otherMovie._title = "Avatar";
        otherMovie._year = 2009;
        otherMovie._rating = "PG-13";
        otherMovie._runtime = 162;

        favoritMovie.Display();

        DisplayMovie(favoritMovie);
        DisplayMovie(otherMovie);


    }

    static void DisplayMovie(Movie aMovie)
    {
        Console.WriteLine($"{aMovie._title} - {aMovie._year}");
    }
}