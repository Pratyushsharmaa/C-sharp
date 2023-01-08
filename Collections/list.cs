using System;
using System.Collections.Generic; //List is a generic collection
namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(10);
            li.Add(11);
            li.Add(12);
            li.Add(13);
            
            foreach (int i in li) //print all values
            {
                Console.WriteLine(i+ " ");
                Console.ReadLine();
            }

            // Insert values in list
            li.Insert(2, 15);
            foreach (int i in li) //print all values
            {
                Console.WriteLine(i + " ");
                Console.ReadLine();
            }

            // Delete values from list
            li.RemoveAt(3);
            foreach (int i in li) //print all values
            {
                Console.WriteLine(i + " ");
                Console.ReadLine();
            }
        }
    }
}
