using System;

namespace Homework2_loops_and_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //task#3 - count the duplicated letters in the char array and show the maximum value

            //creating a source array of characters:
            char[] source_array_of_letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'v', 'u', 'w', 'x', 'y', 'z' };

            //creating and populating an array that should be processed. Feel free to vary length_of_array_to_be_processed to achieve different cases, e.g. no duplicates, multiple sequences of duplicates, etc.
            int length_of_array_to_be_processed = 25;
            char[] array_to_be_processed = new char [length_of_array_to_be_processed];
            for (int i = 0; i < array_to_be_processed.Length; i++)
                {
                    Random rnd = new Random();
                    array_to_be_processed[i] = source_array_of_letters[rnd.Next(source_array_of_letters.Length)];
                }

            //displaying the generated array that should be processed - initial state":
            Console.Write("Task#3 - count the duplicated letters in the char array and show the maximum value\n\nInitial array:\n");
            foreach (char i in array_to_be_processed)
                {
                Console.Write(i + "; ");
                }

            //sorting the array in order get sequences of duplicate values, in order to count the length of these sequenses then and get the maximum
            Array.Sort(array_to_be_processed);
            
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
            for (int i =0; i < array_to_be_processed.Length-1; i++)
                {
                    if (array_to_be_processed[i] == array_to_be_processed[(i + 1)]) //step by step comparing two neighbor values starting from beggining of sorted array
                        {
                        dublicated_character_candidate = array_to_be_processed[i];
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
                        dublicated_character_candidate = array_to_be_processed[i];
                        }
                }

            //posting the results
            Console.Write("\n\nThe result of counting duplicates:");
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
            //task#1 - flip the int array, e.g. 1 2 3 4 5 6 -> 6 5 4 3 2 1

            //creating and populating an array that should be processed. Feel free to vary length_of_array_to_be_processed to achieve different cases, e.g. no duplicates, multiple sequences of duplicates, etc.
            int length_of_array_to_be_processed2 = 20;
            int[] array_to_be_processed2 = new int [length_of_array_to_be_processed2];
            for (int i = 0; i < length_of_array_to_be_processed2; i++)
            {
                Random rnd = new Random();
                array_to_be_processed2[i] = rnd.Next(20);
            }

            //displaying the generated array that should be processed - initial state":
            Console.Write("\n\nTask#1 - rewert the int array, e.g. 1,2,3,4,5,6 -> 6,5,4,3,2,1\n\nInitial array:\n");
            foreach (int i in array_to_be_processed2)
            {
                Console.Write(i + "; ");
            }

            //filling the new array by values from initial array but in rewerted order
            int[] rewerted_array = new int[length_of_array_to_be_processed2];
            for (int i = 0; i < rewerted_array.Length; i++)
                {
                rewerted_array[i] = array_to_be_processed2[length_of_array_to_be_processed2-1];
                length_of_array_to_be_processed2--;
                }

            //posting the results
            Console.Write("\n\nThe result of array rewerting:\n");
            foreach (int i in rewerted_array)
            {
                Console.Write(i + "; ");
            }
            Console.Write("\n\n--------------------------------------------");
        }
    }
}
