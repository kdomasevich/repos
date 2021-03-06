using System;

namespace Homework2_loops_and_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {        
            //task#1 - flip the int array, e.g. 1 2 3 4 5 6 -> 6 5 4 3 2 1

            //creating and populating an array that should be processed. Feel free to vary length_of_array_to_be_processed to achieve different cases, e.g. no duplicates, multiple sequences of duplicates, etc.
            int length_of_array_to_be_processed1 = 15;
            int[] array_to_be_processed1 = new int [length_of_array_to_be_processed1];
            for (int i = 0; i < length_of_array_to_be_processed1; i++)
                {
                Random rnd = new Random();
                array_to_be_processed1[i] = rnd.Next(100);
                }

            //displaying the generated array that should be processed - initial state":
            Console.Write("Task#1 - rewert the int array, e.g. 1,2,3,4,5,6 -> 6,5,4,3,2,1\n\nInitial array:\n");
            foreach (int i in array_to_be_processed1)
                {
                Console.Write(i + "; ");
                }

            //filling the new array by values from initial array but in rewerted order
            int[] rewerted_array = new int[length_of_array_to_be_processed1];
            for (int i = 0; i < rewerted_array.Length; i++)
                {
                rewerted_array[i] = array_to_be_processed1[length_of_array_to_be_processed1 - 1];
                length_of_array_to_be_processed1--;
                }

            //posting the results
            Console.Write("\n\nThe result of task#1 processing - rewerted array:\n");
            foreach (int i in rewerted_array)
                {
                Console.Write(i + "; ");
                }
            Console.Write("\n\n--------------------------------------------");

            //task#2 - find minimum and maximum values in the int array and replace each other, e.g. 1 2 3 4 5 6 -> 6 2 3 4 5 1

            //creating and populating an array that should be processed. Feel free to vary length_of_array_to_be_processed to achieve different cases, e.g. no duplicates, multiple sequences of duplicates, etc.
            int length_of_array_to_be_processed2 = 10;
            int[] array_to_be_processed2 = new int[length_of_array_to_be_processed2];
            for (int i = 0; i < length_of_array_to_be_processed2; i++)
                {
                Random rnd = new Random();
                array_to_be_processed2[i] = rnd.Next(50);
                }

            //displaying the generated array that should be processed - initial state":
            Console.Write("\n\nTask#2 - find minimum and maximum values in the int array and replace each other, e.g. 1,2,3,4,5,6 -> 6,2,3,4,5,1\n\nInitial array:\n");
            foreach (int i in array_to_be_processed2)
                {
                Console.Write(i + "; ");
                }

            //finding min and max value in the array
            int min_value = array_to_be_processed2[0];
            int min_value_index = 0;
            int max_value = array_to_be_processed2[0];
            int max_value_index = 0;
            bool multiple_min_or_max_values = false; //handling the case when there are multiple min or max values, so unable to replace many to 1 or vice versa  
            for (int i = 1; i < array_to_be_processed2.Length; i++)
                {
                if (array_to_be_processed2[i] > max_value)
                    {
                    max_value = array_to_be_processed2[i];
                    max_value_index = i;
                    }
                else if (array_to_be_processed2[i] < min_value)
                    {
                    min_value = array_to_be_processed2[i];
                    min_value_index = i;
                    }
                else if (array_to_be_processed2[i] == min_value || array_to_be_processed2[i] == max_value)
                    {
                    multiple_min_or_max_values = true;
                    }
                }
            Console.Write("\n\nMax value = " + max_value);
            Console.Write("\nMin value = " + min_value);
            //Console.Write("\nIs it multiple min or max values? - " + multiple_min_or_max_values);

            //replacing the min and max if it possible
            if (multiple_min_or_max_values == false)
                {
                array_to_be_processed2[min_value_index] = max_value;
                array_to_be_processed2[max_value_index] = min_value;
                Console.Write("\n\nThe result of task#2 processing:\nThe array with replaced min and max values by each other:\n");
                foreach (int i in array_to_be_processed2)
                    {
                    Console.Write(i + "; ");
                    }
                }
            else
                {
                Console.Write("\n\nThe result of task processing:\nUnable to replace since there are multiple min or max values - unable to replace 1 by many or vice versa");
            }

            Console.Write("\n\n--------------------------------------------");

            //task#3 - count the duplicated letters in the char array and show the maximum value

            //creating a source array of characters:
            char[] source_array_of_letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'v', 'u', 'w', 'x', 'y', 'z' };

            //creating and populating an array that should be processed. Feel free to vary length_of_array_to_be_processed to achieve different cases, e.g. no duplicates, multiple sequences of duplicates, etc.
            int length_of_array_to_be_processed3 = 25;
            char[] array_to_be_processed3 = new char[length_of_array_to_be_processed3];
            for (int i = 0; i < array_to_be_processed3.Length; i++)
            {
                Random rnd = new Random();
                array_to_be_processed3[i] = source_array_of_letters[rnd.Next(source_array_of_letters.Length)];
            }

            //displaying the generated array that should be processed - initial state":
            Console.Write("\nTask#3 - count the duplicated letters in the char array and show the maximum value\n\nInitial array:\n");
            foreach (char i in array_to_be_processed3)
            {
                Console.Write(i + "; ");
            }

            //sorting the array in order get sequences of duplicate values, in order to count the length of these sequenses then and get the maximum
            Array.Sort(array_to_be_processed3);

            /*
            //posting the sorted arrear for easy result verifying 
            Console.Write("\nInitial array after sorting:\n");
            foreach (char i in array_to_be_processed)
                {
                Console.Write(i + "; ");
                }
            Console.Write(" \n");
            */

            //counting the duplicates in sorted array
            char dublicated_character_candidate; //need to ask question to Igor, why implisit inicialization works here, but not working 2nd line below
            int current_length_of_sequence_of_duplicates = 0;
            char carachter_that_was_dublicated_maximum_times = default; //need to ask question to Igor, why explisit inicialization requiered in order to avoid Compiler Error CS0165 during posting results below
            int maximum_quantity_of_duplicates = 0;
            bool multiple_sequences_of_duplicates_with_same_length = false;
            for (int i = 0; i < array_to_be_processed3.Length - 1; i++)
            {
                if (array_to_be_processed3[i] == array_to_be_processed3[(i + 1)]) //step by step comparing two neighbor values starting from beggining of sorted array
                {
                    dublicated_character_candidate = array_to_be_processed3[i];
                    current_length_of_sequence_of_duplicates++;
                    if (current_length_of_sequence_of_duplicates > maximum_quantity_of_duplicates) //handling the case when when we found bigger sequence od duplicates than the current
                    {
                        maximum_quantity_of_duplicates = current_length_of_sequence_of_duplicates;
                        carachter_that_was_dublicated_maximum_times = dublicated_character_candidate;
                        multiple_sequences_of_duplicates_with_same_length = false;
                    }
                    else if (current_length_of_sequence_of_duplicates == maximum_quantity_of_duplicates && current_length_of_sequence_of_duplicates >= 1) //handling the case when we have sequences with the same length
                    {
                        multiple_sequences_of_duplicates_with_same_length = true;
                        maximum_quantity_of_duplicates = current_length_of_sequence_of_duplicates;
                        carachter_that_was_dublicated_maximum_times = dublicated_character_candidate;
                    }
                }
                else //handling the case when there are no dublicates at all
                {
                    current_length_of_sequence_of_duplicates = 0;
                    dublicated_character_candidate = array_to_be_processed3[i];
                }
            }

            //posting the results
            Console.Write("\n\nThe result of task processing:");
            maximum_quantity_of_duplicates++; //need to swich from computing counting (start from 0) to the human type (start from 1) 
            if (maximum_quantity_of_duplicates == 1)
            {
                Console.Write("\nThere are no duplicates in the array\n");
            }
            else if (multiple_sequences_of_duplicates_with_same_length == false && maximum_quantity_of_duplicates > 1)
            {
                Console.Write("\nLetter: \"" + carachter_that_was_dublicated_maximum_times + "\" was duplicated " + maximum_quantity_of_duplicates + " times in the array\n");
            }
            else
            {
                Console.Write("\nThere are multiple letters in the array that are duplicated the same times. \nFor example, letter \"" + carachter_that_was_dublicated_maximum_times + "\" was duplicated " + maximum_quantity_of_duplicates + " times in the array\n");
            }
            Console.Write("\n--------------------------------------------");
        }
    }
}
