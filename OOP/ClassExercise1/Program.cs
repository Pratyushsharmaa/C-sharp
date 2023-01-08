//Print full name using class.

using System;

namespace ClassExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human fname = new Human();
            fname.firstName = "Pratyush";
            fname.lastName = "Sharma";
            fname.IntroduceMyself();
            


            Human next = new Human();
            next.firstName = "David";
            next.lastName = "Mil";
            next.IntroduceMyself();
            Console.ReadKey();

        }
    }
}
