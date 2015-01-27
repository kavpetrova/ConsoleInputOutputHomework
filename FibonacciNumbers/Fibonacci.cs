/*Problem 10. Fibonacci Numbers

Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Note: You may need to learn how to use loops.*/
using System;

    class Fibonacci
    {
        static void Main()
        {
            Console.Write("Type number for n: ");
            long n = long.Parse(Console.ReadLine());
            long fiboTemA = 0;
            long fiboTempB = 1;
            for (long i = 0; i < n; i++)
            {
                Console.Write(fiboTemA + " ");
                long temp = fiboTemA;
                fiboTemA = fiboTempB;
                fiboTempB = temp + fiboTempB;
            }
        }
    }

