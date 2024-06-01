
using System;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string : ");
            string input = Console.ReadLine();

            int length = 1;
            foreach (char c in input)
            {
                length++;
            }

            Console.WriteLine("Length of the string is : " + length);
        }
    }
}