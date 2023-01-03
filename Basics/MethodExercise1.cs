/*Please go ahead and create three variables with names of your friends.
Then create a Method "GreetFriend" which writes something like: "Hi Frank, my friend!" onto the console, once it is called.
Where "Frank" should be replaced with the Name behind the argument given to the Method when it's called. So the method will need a parameter (decide which DataType will be best). 

Greet all your three friends.

*/

using System;

namespace MethodsExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Friend1 = "Robert";
            string Friend2 = "David";
            string Friend3 = "Ram";

            GreetFriend(Friend3);
        }
        
        public static void GreetFriend(string FriendName)
        {
            Console.WriteLine("Hi!" + FriendName + " my friend");
        }
    }
}
