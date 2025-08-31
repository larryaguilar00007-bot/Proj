using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to C# Sample Program.");

            // Ask for user's name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Ask for user's age
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Process and display output
            Console.WriteLine($"\nNice to meet you, {name}!");
            Console.WriteLine($"Next year, you will be {age + 1} years old.");

            // Keep console open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
