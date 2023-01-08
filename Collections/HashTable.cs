//Collections: Hashtable

using System;
using System.Collections;
namespace HathTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Fname", "Pratyush");
            ht.Add("Lname", "Sharma");
            ht.Add("Phone", 982671082);
            ht.Add("Empid", 783937);
            ht.Add("Location", "Gurgaon");

            //print empid from hashtable
           Console.WriteLine(ht["Empid"]);
           Console.ReadLine();

            //Every value has a hashcode. Print hashcode for fname
            Console.WriteLine("Fname".GetHashCode());

            //print ALL keys in hashtable
            foreach (object obj in ht.Keys)
            {
                Console.WriteLine(obj);
            }

            //print ALL values in hashtable
            foreach (object obj in ht.Values)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
