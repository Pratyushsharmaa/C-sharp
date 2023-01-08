//ArrayList size reallocation (auto-resizing). No size limitation.
//Insert value in middle.
//Print using foreach.

using System;
using System.Collections; //this contains ArrayList
namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList AL = new ArrayList(); //no capacity initialized
            Console.WriteLine(AL.Capacity);
            //output = 0 because list is empty
            // add value in arraylist
            AL.Add(100);
            Console.WriteLine(AL.Capacity);
            // output = 4 because size is reallocated upto 4 values
            AL.Add(200); AL.Add(300); AL.Add(400);
            //still output=4 because 4 values entered
            AL.Add(500);
            Console.WriteLine(AL.Capacity);
            //size reallocated to 8, then 16,32,64 and so on.



            //insert value in middle (index, value)
            AL.Insert(3, 350); 


            //print all values in one line
            foreach (object obj in AL) 
            {
                Console.WriteLine(obj + " ");
            
            }

            ArrayList al = new ArrayList(5);  //output starts from capacity = 5 till 5 values are filled then 10,20,40 and so on.
            Console.WriteLine(al.Capacity);
            al.Add(100); al.Add(200); al.Add(300);
            Console.WriteLine(al.Capacity);
            al.Add(100); al.Add(200); al.Add(300);
            Console.WriteLine(al.Capacity);
        }
    }
}
