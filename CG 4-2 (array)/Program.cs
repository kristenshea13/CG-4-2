using System;

namespace CG_4_2__array_
{
    class Program
    {
        static void Main(string[] args)
        {
            //name array, declare array entries as integers, note number of integers in array, and enter all numbers.
            int[] newArray = new int[6] { 1, 1, 2, 3, 5, 8 };

            //to copy each number into the variable "number" and then print it to the console.
            foreach (var number in newArray)
            {
                Console.WriteLine(number);
            }


            Console.ReadLine();




        }
    }
}
