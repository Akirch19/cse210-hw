using System;

class Program
{
    static void Main(string[] args)
    {
    {   string Inputname = promptInputname();
        int Inputnumber = promptInputnumber();
        int squared = squarednumber(Inputnumber);
        DisplayResult(Inputname, squared);

    {
        Console.WriteLine("Welcome to the program!");
    }

    //name
    static string promptInputname()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    //number
    static int promptInputnumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    //square
    static int squarednumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    }
    }
}