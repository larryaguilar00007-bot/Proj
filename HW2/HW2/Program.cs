using System;

using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Console.Write("Enter row: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter col: ");
        int cols = int.Parse(Console.ReadLine());


        List<List<double>> matrix = new List<List<double>>();


        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine($"Row {i + 1}");
            List<double> row = new List<double>();
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Enter number{j + 1}: ");
                double num = double.Parse(Console.ReadLine());
                row.Add(num);
            }
            matrix.Add(row);
        }


        Console.WriteLine("\nThe numbers are:");
        double sum = 0;
        double count = 0;

        foreach (var row in matrix)
        {
            foreach (var num in row)
            {
                Console.Write(num + ".0 ");
                sum += num;
                count++;
            }
            Console.WriteLine();
        }

        double average = sum / count;


        Console.WriteLine($"\nSum: {sum} ; Average: {average}");
        Console.ReadKey();
    }
}

