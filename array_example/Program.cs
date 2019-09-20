/* Author: Robert Nazinitsky
 * Class: ISM 4300
 * Date: 9/19/19
 * Description: Practice using arrays, randomly generates integers into an array and then prints.
 */
using System;

namespace array_example
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //initialize variables
                Random rand = new Random();
                int[] numbers = new int[25];
                int counter = 1;

                //for the length (number of indexes) of the array, assign a random value between 1 and 100.
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rand.Next(1, 100);
                }

                //for each element in the array write to the console about its position and its value.
                //note that position is not in reference to the index, but the amount of numbers displayed.
                foreach (int i in numbers)
                {
                    Console.WriteLine("The element #" + counter + " in the array has a value of: " + i);
                    counter++;
                }
            }
            catch
            {
                Console.WriteLine("An unknown error has occured.");
            }
        }
    }
}
