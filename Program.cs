//
// Reverses an array
// 
// Made by Mekrou on 01/30/2020
//

using System;

namespace ReversingAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = GenerateArray(10, 1, 956);
            Console.Write("Original Array: ");
            PrintArray(array);

            int[] reversedArray = ReverseArray(array);
            Console.Write("Reversed Array: ");
            PrintArray(reversedArray);
            
        }

        // Generates an int[] array with random numbers.
        static int[] GenerateArray(int size, int min, int max)
        {
            var rand = new Random();

            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(min, max);
            }

            return array;
        }

        /// <summary>
        /// Reverses an array using a for loop and a temp variable (explained below!)  
        /// </summary>
        /// <param name="array">The array that will be reversed</param>
        /// <returns>Returns the reversed array (*NOT* a copy)</returns>
        static int[] ReverseArray(int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length / 2; i++)
            {
                // Since arrays are 0-based, the amount of indices we have is array.Length - 1. If we subtract our current index from that 
                // we get the number on the other "side"
                // of the array.

                // we have to store the value we are replacing with to replace the other side
                temp = array[i];

                // switching values:
                array[i] = array[array.Length - i - 1];

                // replacing the other side.
                array[array.Length - i - 1] = temp;
            }
            return array;
        }

        // Simply prints the passed array.
        static void PrintArray(int[] array)
        {
            foreach ( int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

    }
}