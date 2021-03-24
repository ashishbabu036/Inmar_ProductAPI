using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Part
{
    class Program
    {
        public static void PrintString()
        {
            for(int i=1;i<=100;i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("fizzbuzz");
                else if(i % 3 == 0)
                    Console.WriteLine("fizz");
                else if(i%5 == 0)
                    Console.WriteLine("buzz");
            }
        }

        public static void ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            char[] reverseCharArray = new char[charArray.Length];
            for(int i=0;i<charArray.Length;i++)
            {
                reverseCharArray[charArray.Length - 1 -i] = charArray[i];
            }
            Console.WriteLine(new String(reverseCharArray));
        }
        static void Main(string[] args)
        {
            PrintString();
            // Get input String
            string input = Console.ReadLine();
            ReverseString(input);
            Console.Read();
        }
    }
}
