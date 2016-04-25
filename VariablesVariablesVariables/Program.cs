using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VariablesVariablesVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World";
            int t = 1492;
            bool hasDog = false;
            var v = DateTime.Today;
            decimal w = 5.45m;
            char x = 'X';

            Console.WriteLine($"{s}");
            Console.WriteLine($"Columbus sailed the world in {t}.");
            Console.WriteLine($"It is {hasDog} that I have a dog at home.");
            Console.WriteLine($"Today is {v}.");
            Console.WriteLine($"I spent {w} on a cheeseburger.");
            Console.WriteLine($"{x} marks the spot.");

            Console.WriteLine();

            string[] movies = new string[] { "Friday", "Clerks", "Pulp Fiction", "Summer School" };
            Console.WriteLine(movies[0]);
            Console.WriteLine(movies[1]);
            Console.WriteLine(movies[2]);
            Console.WriteLine(movies[3]);

            Console.WriteLine();

            var me = new { name = "Tee Link", car = "Maxima", hometown = "Hope, Arkansas", hobby = "fishing" };
            Console.WriteLine("My name is " + me.name + ". I drive a " + me.car + ". I am from " + me.hometown + ". I enjoy " + me.hobby + ".");

            Console.WriteLine();

            var films = new[]
            {
                new {title = "Friday", year = 1995, director = "F. Gary Gray"},
                new {title = "Clerk", year = 1992, director = "Kevin Smith"},
                new {title = "Pulp Fiction", year = 1994, director = "Quentin Tarantino"},
                new {title = "Summer School", year = 1987, director = "Carl Reiner"}
            };

            foreach (var f in films)
            {
                Console.WriteLine(f.title + " was released in " + f.year + " and was directed by " + f.director + ".");
            }
            Console.ReadLine();

        }

    }

    
}
