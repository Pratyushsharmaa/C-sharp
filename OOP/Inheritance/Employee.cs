using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
   public class Employee
    {
        
        
            public string FirstName;
            public string LastName;
            public int EmployeeNumber;
        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " " + EmployeeNumber);
        }
        
    }
}
