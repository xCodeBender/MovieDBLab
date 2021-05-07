using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MovieDBFirstLab
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Movie Mania");
            Console.WriteLine();
            Console.WriteLine("Movie Menu");
            Console.WriteLine("1. Search by Movie Genre");
            Console.WriteLine("2. Search by Movie Title");
            string pick = Console.ReadLine();
            if(pick  == "1")
            {
                GenreList();
            } 
            else if (pick == "2")
            {
                TitleList();
            } 
            
            //MovieList();
            
        }

        static void GenreList()
        {
            Console.WriteLine("Enter a genre: ");
            string input = Console.ReadLine();
            using (var context = new MovieDBContext())
            {
                
                foreach (Movie movie in context.Movies)
                {
                    if (input == movie.Genre)
                    {
                        Console.WriteLine(movie.Title);
                    }
                }
            }
                
            
                //var genreList = context.Movies.Where(m => m.Genre == input);
        }

        static void TitleList()
        {
            Console.WriteLine("Enter a title: ");
            string inputT = Console.ReadLine();
            using (var context = new MovieDBContext())

                foreach (Movie m in context.Movies)
                {
                    if (m.Title.ToLower().Contains(inputT))
                    {
                        Console.WriteLine(m.Genre);
                    }
                }
        }

            //using (var context = new MovieDBContext())
            //{
            //    Console.WriteLine("What title are you are you interested in?");
            //    string input2 = Console.ReadLine();

            //    var all = context.Movies.ToList();
            //    foreach (Movie m in all)
            //    {
            //        if (m.Title == input2)
            //        {
            //            Console.WriteLine($"Movies {m.Genre}");
            //        }

            //    }
            //}


        

      
        static void MovieList()
        {
            using (var context = new MovieDBContext())
            {
                Movie movie1 = new Movie()
                {
                    Title = "Bridesmaids",
                    Genre = "Comedy",
                    Runtime = 132
                };

                Movie movie2 = new Movie()
                {
                    Title = "Pitch Perfect",
                    Genre = "Comedy",
                    Runtime = 112
                };
                Movie movie3 = new Movie()
                {
                    Title = "Superbad",
                    Genre = "Comedy",
                    Runtime = 119
                };
                Movie movie4 = new Movie()
                {
                    Title = "Unstoppable",
                    Genre = "Action",
                    Runtime = 99
                };

                Movie movie5 = new Movie()
                {
                    Title = "Shooter",
                    Genre = "Action",
                    Runtime = 126
                };

                Movie movie6 = new Movie()
                {
                    Title = "Eagle Eye",
                    Genre = "Action",
                    Runtime = 118
                };

                Movie movie7 = new Movie()
                {
                    Title = "Up",
                    Genre = "Animation",
                    Runtime = 96
                };

                Movie movie8 = new Movie()
                {
                    Title = "Inside Out",
                    Genre = "Animation",
                    Runtime = 102
                };

                Movie movie9 = new Movie()
                {
                    Title = "Toy Story",
                    Genre = "Animation",
                    Runtime = 71
                };

                Movie movie10 = new Movie()
                {
                    Title = "Wall-E",
                    Genre = "Comedy",
                    Runtime = 103
                };

                context.Movies.Add(movie1);
                context.Movies.Add(movie2);
                context.Movies.Add(movie3);
                context.Movies.Add(movie4);
                context.Movies.Add(movie5);
                context.Movies.Add(movie6);
                context.Movies.Add(movie7);
                context.Movies.Add(movie8);
                context.Movies.Add(movie9);
                context.Movies.Add(movie10);

                context.SaveChanges();

            }
        }
    }
}
