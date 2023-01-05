//Greet friends using foreach loop.

using System;

namespace foreachloop
{
    class Program
{
    static void Main(string[] args)
    {
        string[] myFriends = { "David", "Chris", "Male", "Shiv" };
        foreach (string name in myFriends)
        {
            Console.WriteLine("Hi,my friend {0}", name);
        }
        Console.ReadKey();
    }
}
}

