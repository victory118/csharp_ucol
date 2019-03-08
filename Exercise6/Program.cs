using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter angle in degrees: ");

            float angleDegrees = float.Parse(Console.ReadLine());
            float angleRadians = (float) (angleDegrees * Math.PI / 180);
            Console.WriteLine("Cosine of Angle: " + Math.Cos(angleRadians));
            Console.WriteLine("Sine of Angle: " + Math.Sin(angleRadians));
        }
    }
}
