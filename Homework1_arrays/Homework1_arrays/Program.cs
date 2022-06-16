using System;

namespace Homework1_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[3];
            long[] array2 = new long[3];
            float[] array3 = new float[3];

            /*Random rnd = new Random(); 
            array1[0] = (int)rnd.Next();
            array2[0] = (long)rnd.Next(); //couldn't find own easy solution how to generate long random values, except approach from https://stackoverflow.com/questions/6651554/random-number-in-long-range-is-this-the-way that i'm not fully understand
            array3[0] = (float)rnd.NextDouble();
            */

            array1[0] = -4;
            array2[0] = 3780786032;
            array3[0] = (float)1.54587;

            array1[1] = (int)Math.Pow(array1[0], 2);
            array2[1] = (long)Math.Pow(array2[0], 2);
            array3[1] = (float)Math.Pow(array3[0], 2);

            array1[2] = array1[0] + array1[1];
            array2[2] = array2[0] + array2[1];
            array3[2] = array3[0] + array3[1];

            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Array1, value" + i + ": " + array1[i] + "; \tArray2, value" + i + ": " + array2[i] + "; \tArray3, value" + i + ": " + array3[i]);
                i++;
            }
        }
    }
}
