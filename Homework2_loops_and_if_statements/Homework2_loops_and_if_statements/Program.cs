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

            //creating and populating an array to be processed:
            int length_of_array_to_be_processed = 25;
            char[] array_to_be_processed = new char [length_of_array_to_be_processed];
            for (int i = 0; i < array_to_be_processed.Length; i++)
                {
                    Random rnd = new Random();
                    array_to_be_processed[i] = source_array_of_letters[rnd.Next(source_array_of_letters.Length)];
                }

            //displaying the array to be processed (initial state)":
            Console.Write("Initial array:\n");
            foreach (char i in array_to_be_processed)
                {
                Console.Write(i + "; ");
                }

            //sorting the array in order get duplicates one by one, and then count the length of "rows" of duplicates
            Array.Sort(array_to_be_processed);
            Console.Write("\nInitial array after sorting:\n");
            foreach (char i in array_to_be_processed)
                {
                Console.Write(i + "; ");
                }
            Console.Write(" \n");

            //counting the duplicates in sorted array
            char current_dublicated_character = default;
            int current_quantity_of_duplicates = 0;
            char final_dublicated_character = default;
            int final_quantity_of_duplicates = 0;
            bool are_there_multiple_duplicates_with_same_quantity = false;
            //int n = 0;
            for (int i =0; i < array_to_be_processed.Length-1; i++)
                {
                    if (array_to_be_processed[i] == array_to_be_processed[(i + 1)])
                        {
                        current_dublicated_character = array_to_be_processed[i];
                        current_quantity_of_duplicates++;
                        if (current_quantity_of_duplicates > final_quantity_of_duplicates)
                            {
                            final_quantity_of_duplicates = current_quantity_of_duplicates;
                            final_dublicated_character = current_dublicated_character;
                            are_there_multiple_duplicates_with_same_quantity = false;
                             }
                        else if (current_quantity_of_duplicates == final_quantity_of_duplicates && current_quantity_of_duplicates >= 1)
                            {
                            are_there_multiple_duplicates_with_same_quantity = true;
                            final_quantity_of_duplicates = current_quantity_of_duplicates;
                            final_dublicated_character = current_dublicated_character;
                            }
                        }
                    else
                        {
                        current_quantity_of_duplicates = 0;
                        current_dublicated_character = array_to_be_processed[i];
                        }
                }

            //posting the results
            Console.Write("\nThe result of counting duplicates:");
            if (final_quantity_of_duplicates == 0
                )
                {
                Console.Write("\nThere are no duplicates in the array\n");
                }
            else if (are_there_multiple_duplicates_with_same_quantity == false && final_quantity_of_duplicates > 0)
                {
                final_quantity_of_duplicates++;
                Console.Write("\nLetter: " + final_dublicated_character + " was duplicated " + final_quantity_of_duplicates + " times in the array\n");
                }
            else
                {
                final_quantity_of_duplicates++;
                Console.Write("\nThere are multiple letters in the array that are duplicated the same times. \nFor example, letter \"" + final_dublicated_character + "\" was duplicated " + final_quantity_of_duplicates + " times in the array\n");
                }
            }
    }
}
