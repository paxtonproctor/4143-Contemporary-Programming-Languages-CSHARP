/// Paxton Proctor
/// 8/29/2022
/// Create a simple program that takes user input and finds the smallest and largest number, sum and average using console application.

using System;
using System.Drawing;

namespace Program_2 
{
    internal class Program
    {
        static void Main()
        {

            // declarations
            int sum;
            double average;
            int[] a = new int[3];

            // read user input
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter integers: " + i);
                a[i] = int.Parse(Console.ReadLine());
            }

            // declaration for largest and smallest
            int largest = a[0];
            int smallest = a[0];

            // loop through 3 times
            for (int i = 0; i < 3; i++)
            {
                if (a[i] > largest)
                {
                    largest = a[i];
                }
                if (a[i] < smallest)
                {
                    smallest = a[i];
                }
            }

            sum = a[0] + a[1] + a[2]; // add numbers
            average = sum / 3; // average of num

            Console.WriteLine("Sum is: " + sum);
            Console.WriteLine("Average is: " + average);

            
            //Display the Smallest value  
            Console.WriteLine("The smallest Value is: " + a[0]);  
            //Display the Biggest Value  
            Console.WriteLine("The Largest Value is: " + a[2]);
        }
    }
}
