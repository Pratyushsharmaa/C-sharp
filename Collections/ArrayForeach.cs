using System;

namespace ArrayForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                num[i] = i+10;
            }

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("{0} = {1}", j, num[j]);
            }
            Console.ReadKey();

            //foreach

            int counter = 0;
            foreach(int k in num) //in num means it will run only the number of values that are initialized
            {
                Console.WriteLine("{0} = {1}", counter, k);
                counter++;
            }
        }
    }
}
