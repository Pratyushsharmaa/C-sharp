using System;

namespace AdditionUsingMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Add(10,20));
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
