using System;

namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! This program will calculate the distance and angle between two points.");

            Console.Write("Enter first x value: ");
            float point1X = float.Parse(Console.ReadLine());

            Console.Write("Enter first y value: ");
            float point1Y = float.Parse(Console.ReadLine());

            Console.Write("Enter second x value: ");
            float point2X = float.Parse(Console.ReadLine());

            Console.Write("Enter second y value: ");
            float point2Y = float.Parse(Console.ReadLine());

            float distance = (float) Math.Sqrt(Math.Pow(point1X - point2X,2) + Math.Pow(point1Y - point2Y,2));
            float angleRadians = (float) Math.Atan2(point2Y-point1Y, point2X - point1X);
            float angleDegrees = (float) (angleRadians * 180 / Math.PI);

            Console.WriteLine("Distance between points: " + distance);
            Console.WriteLine("Angle between points: " + angleDegrees); 

        }
    }
}
