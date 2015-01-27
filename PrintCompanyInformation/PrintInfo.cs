/*Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name,
age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.*/
using System;

class PrintInfo
{
    static void Main()
    {
        Console.WriteLine("Hello, in manager's page!");
        Console.Write("Please enter your first name: ");
        string FirstName = Console.ReadLine();
        Console.Write("Please enter your last name: ");
        string LastName = Console.ReadLine();
        Console.Write("Your company is?: ");
        string CompanyName = Console.ReadLine();
        Console.Write("Please enter your password:");
        object Password = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Your personal page in manager.com :");
        Console.WriteLine();
        Console.WriteLine("Your name is: {0} {1}", FirstName, LastName);
        Console.WriteLine("Adress: str. James Bond Nº17");
        Console.WriteLine("Your number is: +4400 3434 3434 ");
        Console.WriteLine("Web: www.{0}.com", FirstName + LastName);
        Console.WriteLine("Your company is: {0}", CompanyName);
        Console.WriteLine("Company adress: str. James Bond Nº007");
        Console.WriteLine("Company's number is: +4400 666 666 ");
        Console.WriteLine("Fax number: +4400 121212");
        Console.WriteLine("Your password is: {0}", Password);
        

    }
}

