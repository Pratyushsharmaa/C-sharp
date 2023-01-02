using System;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "13";
            string secondString = "17";
            int num1 = Int32.Parse(firstString);
            int num2 = Int32.Parse(secondString);
            int result = num1 + num2;
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
