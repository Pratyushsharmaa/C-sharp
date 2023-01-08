using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercise1
{
    class Human
    {
        public string firstName;
        public string lastName;

        public void IntroduceMyself()     //member variable
        {
            Console.WriteLine("Hi! My name is: {0} {1}", firstName, lastName);
        }
    }
}
