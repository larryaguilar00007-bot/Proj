using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int x = 1; x <= 5; x++)
            {
                for(int i= 6; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine(x);
            }
            //int j;
           // Console.Write("Enter a size: ");
           // j = int.Parse(Console.ReadLine());

            //int a;

           // while (true)
            //{
           //     Console.Write("Enter number: ");
            //    a = int.Parse(Console.ReadLine());
             //   Console.WriteLine(a);
               
                
           // }
           // string str, str_output;
           /* Console.Write("Enter a str: ");
            str = Console.ReadLine();
            for (int x = 0; x < str.Length; x++)
            {
                str_output = str[x].ToString() == "a" ? "Vowel" ;
                str[x].ToString() == "e" ? "Vowel" ;
                str[x].ToString() == "i" ? "Vowel" ;
                str[x].ToString() == "o" ? "Vowel" ;
                str[x].ToString() == "u" ? "Vowel" ;
                Console.WriteLine($"{str[x]} {str_output}");

            }
           */
            int row, column, search;

            Console.Write("Enter a Row size: ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Enter a Column: ");
            column = int.Parse(Console.ReadLine());
            Console.Write("Search: ");
            search = int.Parse(Console.ReadLine());

            if(row == column)
            {
                Console.Write(" ".Length +(row * column));
            }
             
            Console.ReadKey();
        }    
    }
}
