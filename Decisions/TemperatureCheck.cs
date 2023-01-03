//if-else using try parse method

using System;

namespace TemperatureCheck
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter current temperature");
            string temperature = Console.ReadLine();
            int numTemp = 0; 
            int number;
            if(int.TryParse(temperature,out number))
            {
                numTemp = number;
            }
            if (numTemp < 20)
            {
                Console.WriteLine("Winters");
            }
            else
            {
                Console.WriteLine("Summers");
            }
        }
    }
}
