using System;

namespace Classes4
{
    class Program
    {
	    static void Main(string[] args)
        {
		    Movie movie = new Movie("PG-13", "Eon Productions", "Casino Royale");
		    Movie movie1 = new Movie("PG-13", "Buena Vista International", "Glass");
		    Movie movie2 = new Movie("PG", "Columbia Pictures", "Spider-Man: Into the Spider-Verse");
		    Console.Write("The movie title is " + movie.GetTitle());
		    Console.Write(", the studio " + movie.Getstudio());
		    Console.Write(", and the rating " + movie.GetRating());
		    Console.WriteLine("\n");
		    Console.WriteLine("-----------------------------------");
		    Console.Write("The movie title is " + movie1.GetTitle());
		    Console.Write(", the studio " + movie1.Getstudio());
		    Console.Write(", and the rating " + movie1.GetRating());
		    Console.WriteLine("\n");
		    Console.WriteLine("-----------------------------------");
		    Console.Write("The movie title is " + movie2.GetTitle());
		    Console.Write(", the studio " + movie2.Getstudio());
		    Console.Write(", and the rating " + movie2.GetRating());
		    Console.WriteLine("\n");
		    Console.WriteLine("-----------------------------------");
	    }
    }
}