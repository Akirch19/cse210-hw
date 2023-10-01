using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        string letter = "";


        // for As
        if (percent >= 96)
        {
            letter = "A+";
        }
        
        else if (percent >= 94)
        {
            letter = "A";
        }

         else if (percent >= 90)
        {
            letter = "A-";
        }
        
        // for Bs
        else if (percent >= 86)
        {
            letter = "B+";
        }
        
        else if (percent >= 84)
        {
            letter = "B";
        }

        else if (percent >= 80)
        {
            letter = "B-";
        }

        // for Cs
        else if (percent >= 76)
        {
            letter = "C+";
        }
        
        else if (percent >= 74)
        {
            letter = "C";
        }

        else if (percent >= 70)
        {
            letter = "C";
        }

        // for Ds
        else if (percent >= 66)
        {
            letter = "D+";
        }
        
        else if (percent >= 64)
        {
            letter = "D";
        }

        else if (percent >= 60)
        {
            letter = "D";
        }

        // for F 
        else if (percent >= 56)
        {
            letter = "F+";
        }
        
        else if (percent >= 54)
        {
            letter = "F";
        }

        else
        {
            letter = "F-";
        }

        Console.WriteLine($"Your grade is a: {letter}");
        if (percent <= 70)
        {
            Console.WriteLine("You got this! Try again!");
        }

        else
        {
            Console.WriteLine("Congrats, you passed!");
        }



    }
}