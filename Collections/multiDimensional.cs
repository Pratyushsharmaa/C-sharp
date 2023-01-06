using System;

namespace MultidimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            

                int[,] twoD = new int[,]
                {
                {1,2,3},
                {4,2,6},
                {1,4,7}
                };
                Console.WriteLine("Central value is: {0}", twoD[1, 1]);
            
            string[,,] threeD = new string[,,]
            {
                {
                    {"000","001"},           //indexes 000 and 010
                    {"010", "011"},          //indexes 010 and 011
                    {"Hi", "How are you?"}   //indexes 020 and 021
                },
                {
                    {"100","101" },
                    {"110","111"},
                    {"Good","Thanks"}
                    }
                };
            Console.WriteLine(threeD[0,2,0]);
            Console.Read();


            //initialise a specific array, eg 3 rows and 2 columns
            int[,] twoDimensional = new int[3, 2]
            {
                {1,2},
                {3,4},
                {5,6}
            };
            //change value 4 to 9
            twoDimensional[1,2] = 9;
            Console.WriteLine(twoDimensional[1,2]);
            Console.Read();
            }
        }
    }

