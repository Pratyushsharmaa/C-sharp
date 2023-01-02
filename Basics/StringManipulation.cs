using System;

namespace Stringmanipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ram";
            int age = 28;
            string job = "Engineer";
            {
                //string concatenation
                Console.WriteLine("String Concatenation");
                Console.WriteLine("Hi!" + "My name is " + name + " and age is " + age + " and job is " + job);
                

                //string formatting
                Console.WriteLine("String Formatting");
                Console.WriteLine("Hi!My name is {0} and age is {1} and job is {2}", name, age, job);
                

                //string interpolation
                //use $ at the start
                Console.WriteLine("String interpolation");
                Console.WriteLine($"Hi!My name is {name} and age is {age} and job is {job}");
            }

        }
    }
}
