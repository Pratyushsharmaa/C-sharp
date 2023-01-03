//Basic code to create a method and call it.

using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Random();                                    //method is called
            RandomSpecific("Called from method named RandomSpecific");
        }
            public static void Random()                  //method is created
            {
                Console.WriteLine("Called from method named Random");
                
            }
            public static void RandomSpecific(string myText)
        {
            Console.WriteLine(myText);

        }
        }
    }

