using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prep2");

        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;

        /*if (number >= a)
        {
            Console.WriteLine("You have an A.");
        }
        else if (number >= b && number < a)
        {
            Console.WriteLine("You have a B.");
        }
        else if (number >= c && number < b)
        {
            Console.WriteLine("You have a C.");
        }
        else if (number >= d && number < c)
        {
            Console.WriteLine("You have a D.");
        }
        else
        {
            Console.WriteLine("You are failing.");
        }*/

        string letter = "";

        if (number >= a)
        {
            letter = "A";
        }
        else if (number >= b && number < a)
        {
            letter = "B";
        }
        else if (number >= c && number < b)
        {
            letter = "C";
        }
        else if (number >= d && number < c)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You have a {letter} in the class.");


        if (number >= c)
        {
            Console.WriteLine("You are passing the class");
        }
        else
        {
            Console.WriteLine("You are not passing the class.");
        }

    }
}