using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String: ");
            string name = Console.ReadLine();

            string[] parts = name.Split(',');

            foreach (string part in parts)
            {
                string word = part.Trim();
                Dictionary<char, (int count, char displayChar)> result = GetCharFrequence(word);

                Console.WriteLine();
                int count = 0;
                foreach (var letters in result)
                {
                    count++;
                    Console.Write($"{letters.Value.displayChar}={letters.Value.count}");
                    if (count < result.Count) Console.Write(", ");
                }
                Console.Write(" ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }

        
        public static Dictionary<char, (int count, char displayChar)> GetCharFrequence(string input)
        {
            Dictionary<char, (int count, char displayChar)> nameValue = new Dictionary<char, (int count, char displayChar)>();

            foreach (char l in input)
            {
                if (l == ' ' || l == ',')
                    continue;

                char key = char.ToLower(l); 

                if (nameValue.ContainsKey(key))
                {
                    var temp = nameValue[key];
                    temp.count++;
                    nameValue[key] = temp;
                }
                else
                {
                    
                    nameValue[key] = (1, l);
                }
            }
            return nameValue;
        }
    }

}


