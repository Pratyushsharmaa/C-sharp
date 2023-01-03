using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string userInput = Console.ReadLine();
            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch(FormatException) //for wrong format of input
            {

                Console.WriteLine("Wrong input!");
            }
            catch(OverflowException)  //if string input is too large
            {
                Console.WriteLine("Overflow");
            }
            finally                  //this is always written at last with try-catch, even if no errors
            {
                Console.WriteLine();
            }
        }
    }
}
