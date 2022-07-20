using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string json = File.ReadAllText(@"D:\SoftUni\OOP\Input.txt");
            var movieStarsList = JsonConvert.DeserializeObject<List<MovieStar>>(json);

            foreach (var movieStar in movieStarsList)
            {
                int age = 0;
                age = DateTime.Now.Year - movieStar.DateOfBirth.Year;
                if (DateTime.Now.Year < movieStar.DateOfBirth.DayOfYear)
                {
                    age -= 1;
                }
                Console.WriteLine(movieStar.Name + " " + movieStar.Surname);
                Console.WriteLine(movieStar.Sex);
                Console.WriteLine(movieStar.Nationality);
                Console.WriteLine($"{age} years old");
                Console.WriteLine();
            }
        }
    }
}
