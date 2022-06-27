using System;

namespace Homework3_methods
{
    class Program
    {
        //task#1 - flip the int array, e.g. 1 2 3 4 5 6 -> 6 5 4 3 2 1
        static int[] GenerateIntArray(int lengthOfArrayToBeGenerated) //method to create an array of certain length and populate it by random values in range(0;100)
        {
            int[] generatedArray = new int[lengthOfArrayToBeGenerated];
            for (int i = 0; i < generatedArray.Length; i++)
            {
                Random rnd = new Random();
                generatedArray[i] = rnd.Next(100);
            }
            return generatedArray;
        }

        static int[] FlipTheArray(int[] arrayLocal, int arrayLength) //method to flip an array - filling the new array by values from initial array but in rewerted order
        {
            int[] rewerted_array = new int[arrayLength];
            for (int i = 0; i < rewerted_array.Length; i++)
            {
                rewerted_array[i] = arrayLocal[arrayLength - 1];
                arrayLength--;
            }
            return rewerted_array;
        }

        static void PrintAnArray(int[] arrayLocal) //method to print int arrays
        {
            foreach (int i in arrayLocal)
            {
                Console.Write(i + "; ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int lengthOfArrayToBeProcessed = 15;
            int[] generatedArray = GenerateIntArray(lengthOfArrayToBeProcessed);
            Console.Write("Task#1 - rewert the int array, e.g. 1,2,3,4,5,6 -> 6,5,4,3,2,1\n\nInitial array:\n");
            PrintAnArray(generatedArray); //displaying the generated array that should be processed - initial state":
            int[] rewertedArray = FlipTheArray(generatedArray,lengthOfArrayToBeProcessed);
            Console.Write("\n\nThe result of task#1 processing - rewerted array:\n"); //posting the final results of task1
            PrintAnArray(rewertedArray); 
        }

    }
}
