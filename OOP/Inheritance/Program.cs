using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee(); //object creation
            FTE.FirstName = "Pratyush";
            FTE.LastName = "Sharma";
            FTE.EmployeeNumber = 72393;
            FTE.AnnualSalary = 50000;
            FTE.PrintFullName();
            //Note: cannot retrieve monthly salary.
            

            PartTimeEmployee PTE = new PartTimeEmployee(); //object creation
            PTE.FirstName = "Shaun";
            PTE.LastName = "Mil";
            PTE.EmployeeNumber = 26382;
            PTE.MonthlySalary = 30000;
            PTE.PrintFullName();
        }
    }
}
