using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicnumber = int.Parse(Console.ReadLine());
        int number = -1;

        while (number != magicnumber)
        {
            Console.Write("What is your guess? ");
            number = int.Parse(Console.ReadLine());
            if (magicnumber < number)
            {
                Console.WriteLine("Lower");
            }
            else if (magicnumber > number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }
    }
}