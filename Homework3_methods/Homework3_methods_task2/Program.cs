using System;

namespace Homework3_methods_task2
{
    class Program
    {
        //task#2 - find minimum and maximum values in the int array and replace each other, e.g. 1 2 3 4 5 6 -> 6 2 3 4
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
        static int[] FlipAndReplaceMinAndMaxInArray(int[] arrayLocal, int arrayLength) //method to finding min and max value in the input array, return new array with relayced min and max or exception
        {
            int minValue = arrayLocal[0];
            int minValueIndex = 0;
            int maxValue = arrayLocal[0];
            int maxValueIndex = 0;
            bool multipleMinOrMaxValuesFlag = false; //handling the case when there are multiple min or max values, so unable to replace many to 1 or vice versa  
            for (int i = 1; i < arrayLength; i++)
            {
                if (arrayLocal[i] > maxValue)
                {
                    maxValue = arrayLocal[i];
                    maxValueIndex = i;
                }
                else if (arrayLocal[i] < minValue)
                {
                    minValue = arrayLocal[i];
                    minValueIndex = i;
                }
                else if (arrayLocal[i] == minValue || arrayLocal[i] == maxValue)
                {
                    multipleMinOrMaxValuesFlag = true;
                }
            }
            if (multipleMinOrMaxValuesFlag == true) //until we haven't learned exeptions handling this bad code is kind of workaround - ask mentor to clarify futher how to do it properly
            {
                for (int i = 0; i < arrayLength; i++) //replace initial array values by nulls in order to return such Null array, in order to indicate that there was an exeption "there are multiple min or max values, so unable to replace many to 1 or vice versa"
                {
                    arrayLocal[i] = 0;
                }
                return arrayLocal; //return array with nulls
            }
            else
            {
                arrayLocal[maxValueIndex] = minValue;
                arrayLocal[minValueIndex] = maxValue;
                return arrayLocal; //return array with replaced values
            }

        }
        static void PrintAnArray(int[] arrayLocal) //method to print int arrays //ask how to create method that can print any type of array, not only int
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
            Console.Write("Task#2 - find minimum and maximum values in the int array and replace each other, e.g. 1,2,3,4,5,6 -> 6,2,3,4,5,1\n\nInitial array:\n");
            PrintAnArray(generatedArray); //displaying the generated array that should be processed - initial state"
            int[] replacedArray = FlipAndReplaceMinAndMaxInArray(generatedArray, lengthOfArrayToBeProcessed);
            Console.Write("\nThe result of task#2 processing:\n");
            bool multipleMinOrMaxValuesFlag = false;
            for (int i = 0; i < replacedArray.Length; i++) //processing the exeption via if condition - verifying whether an array has only nulls
            {
                if (replacedArray[i] == 0)
                {
                    multipleMinOrMaxValuesFlag = true;
                }
                else
                {
                    multipleMinOrMaxValuesFlag = false;
                }
            }
            if (multipleMinOrMaxValuesFlag == true)
            {
                Console.Write("Unable to replace since there are multiple min or max values - unable to replace 1 by many or vice versa"); //exception
            }
            else
            {
                Console.Write("The array with replaced min and max values by each other:\n"); //positive result of task#2
                PrintAnArray(replacedArray);
            }
        }
    }
}
