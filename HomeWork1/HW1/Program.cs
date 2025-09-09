using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\nEnter string: ");
                string term = Console.ReadLine();

                if (term == "*")

                    break;

                string original = term;
                string lowercaseOriginal = term.ToLower();
                string reversed = ReverseString(lowercaseOriginal); 
                bool isPalindrome = IsPalindrome(lowercaseOriginal, reversed);

                Console.WriteLine("\n\nOriginal String" + " \tReversed String " + " \tPalindrome?");
                Console.WriteLine($"  {original,-15} \t    {reversed,-15} \t    {(isPalindrome ? "Yes" : "No")}\n");
            }
            Console.WriteLine("\n\n//End execution");
            Console.ReadKey();
        }

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            int left = 0;
            int right = charArray.Length - 1;

            while (left < right)
            {
                char temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = temp;
                left++;
                right--;
            }
            return new string(charArray);
        }

        static bool IsPalindrome(string original, string reversed)
        {
            return original == reversed;
        }
    }
}
    

