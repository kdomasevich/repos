using System;

namespace Homework4_Classes
{
    class Program
    {
        //Task1 - create new class with points X,Y coordinates, initialize array with 5 elements of this class, display them
        //Task2 - create method to sum pair of points from task1
        static void PrintArrayOfClassInstances(PointCoordinate[] localArray) //method to print an array of custom class instances
        {
            foreach (PointCoordinate i in localArray)
            {
                Console.WriteLine("(" + i.xCoordinate + "; " + i.yCoordinate + ")");
            }
        }

        static PointCoordinate SumTwoPoints(PointCoordinate pointA, PointCoordinate pointB) //method to sum two points
        {
            PointCoordinate sum = new PointCoordinate();
            sum.xCoordinate = pointA.xCoordinate + pointB.xCoordinate;
            sum.yCoordinate = pointA.yCoordinate + pointB.yCoordinate;
            return sum;
        }

        static void Main(string[] args)
        {
            PointCoordinate point1 = new PointCoordinate();
            Random rnd = new Random();
            PointCoordinate[] arrayOfPoints = new PointCoordinate[5];      
            for (int i = 0; i < arrayOfPoints.Length; i++) //generating 5 instances of class points
            {
                arrayOfPoints[i] = new PointCoordinate();
                arrayOfPoints[i].xCoordinate = rnd.Next(100);
                arrayOfPoints[i].yCoordinate = rnd.Next(100);
            }
            Console.WriteLine("The List of Points with randomly generated coordinates (X; Y) from the range [0,100]:");
            PrintArrayOfClassInstances(arrayOfPoints); //displaying the results of Task1

            Console.WriteLine("\nThe Sum of first two points from list above:");
            Console.WriteLine("(" + SumTwoPoints(arrayOfPoints[0],arrayOfPoints[1]).xCoordinate + "; " + SumTwoPoints(arrayOfPoints[0], arrayOfPoints[1]).yCoordinate + ")"); //displaying the results of Task2
        }
    }
}
