using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seatwork1
{
    class Program
    {
        public static string IsPrime(int n)
        {
            if (n <= 1)
                return "Composite";
            for (int j = 2; j <= Math.Sqrt(n); j++)
            {
                if (n % j == 0)
                    return "Composite";
            }
            return "Prime";
        }
        public static (double, double) ConvertCurrency(double dollars)
        {
            double pesoRate = 57.17;
            double yenRate = 146.67;
            double pesos = dollars * pesoRate;
            double yen = dollars * yenRate;

            return (pesos, yen);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            string[] numInput = Console.ReadLine().Split(' ');
            foreach( string s in numInput)
            {
                int num = int.Parse(s);
                Console.WriteLine($"{num}\t{IsPrime(num)}");
            }
            Console.WriteLine();

            Console.Write("Enter currency ($): ");
            string[] moneyInput = Console.ReadLine().Split(',');

            Console.WriteLine("\nCurrency Conversion");
            Console.WriteLine("Dollar($)\tPhil Peso(P)\tJpn Yen (y)");
            foreach(string s in moneyInput)
            {
                double dollar = double.Parse(s);
                (double peso, double yen) = ConvertCurrency(dollar);
                Console.WriteLine($"{dollar}\t\t{peso:F2}\t\t{yen:F2}");
            }
            Console.ReadKey();
        }
    }
}
