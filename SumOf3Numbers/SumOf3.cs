/*Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.*/
using System;

    class SumOf3
    {
        static void Main()
        {
            Console.Write("Please enter first number: ");
            double FirstNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter second number: ");
            double SecondNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter third number: ");
            double ThirdNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("The sum is {0}", FirstNumber + SecondNumber + ThirdNumber);
        }
    }

