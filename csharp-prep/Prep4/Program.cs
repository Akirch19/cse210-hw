using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        float userinput = -1;
        while (userinput != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finsihed: ");

            string userResponse = Console.ReadLine();
            userinput = float.Parse(userResponse);

            if (userinput != 0)
            {
                numbers.Add(userinput);
            }
        }

        //part 1
        float total = 0;
        foreach (float number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"The sum is: {total}");

        //part2
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //part 3
        float largest = numbers[0];
        foreach (float number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");



        float smallest = numbers[0];
        foreach (float number in numbers)
        {
            if (number < smallest)
            {
                smallest = number;
            }
        }
        Console.WriteLine($"The smallest number is: {smallest}");
        
    

    }
}