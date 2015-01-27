/*Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c 
of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).*/
using System;

    class Quadratic
    {
        static void Main()
        {
            Console.Write("Please enter number a = ");
            double numberA = double.Parse(Console.ReadLine());
            Console.Write("Please enter number b = ");
            double numberB = double.Parse(Console.ReadLine());
            Console.Write("Please enter number c = ");
            double numberC = double.Parse(Console.ReadLine());
            double discriminant = (numberB * numberB) - 4 * numberA * numberC;
            if (discriminant < 0)
            {
                Console.WriteLine("There are no real roots");
            }
            else
            {
                double discriminantRoot = Math.Sqrt(discriminant);
                double x2 = (-numberB + discriminantRoot) / (2 * numberA);
                double x1 = (-numberB - discriminantRoot) / (2 * numberA);
                Console.WriteLine(x1 == x2 ? "The Equasion got one real root x1 = {0}" : "The Equasion got two real roots x1 = {0}; x2 = {1}"
                , x1, x2);
            }
        }
    }

