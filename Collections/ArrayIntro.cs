using System;

namespace ArrayIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring an array
            int[] grade = new int[5];

            grade[0] = 42;
            grade[1] = 56;
            grade[2] = 53;
            grade[3] = 96;
            grade[4] = 17;
            
            Console.WriteLine("Grades at index[0] is: {0}", grade[0]);
            //Console.ReadKey();

            //change value at grade[0] from 42 to 10
            string input = Console.ReadLine();
            grade[0] = int.Parse(input);      //conversion of grade to int
            Console.WriteLine("Grades at index[0] is: {0}", grade[0]);
            Console.ReadLine();

            //other ways to initialize an array

            int[] grade1 = new int[] { 24, 46, 24, 86, 14 };
            Console.WriteLine("Second way to initialize array is: {0} {1}", grade1[0], grade1[1]); //print first two indexes
            Console.ReadKey();
            int[] grade2 = { 63, 58, 79, 35 };
            Console.WriteLine("Third way to initialize array is: {0}", grade2[0]);
            Console.WriteLine("Length of this array is: {0}", grade2.Length); // print length of this array
            Console.ReadKey();
        }
    }
}
