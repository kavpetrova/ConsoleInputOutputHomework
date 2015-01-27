/*Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.*/
using System;

    class Comparer
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            //Console.WriteLine(a>b ? a:b);
            double greater = Math.Max(a, b);
            Console.WriteLine("The greater number is: " + greater);
        }
    }

