using System;

namespace ArrayIntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstTen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int arrayLength = firstTen.Length;
            Console.WriteLine(firstTen[0]); //print first element
            Console.WriteLine(arrayLength); //print length of an array
            Console.WriteLine(firstTen[arrayLength - 1]); //print last element

            int[] firstFive = new int[] { 5, 4, 3, 2, 1 };
            for (int i = 0; i < firstFive.Length; i++)
            {
                    Console.WriteLine(firstFive[i]);
                    Console.Read();
                }
            
            
        }
    }
}
