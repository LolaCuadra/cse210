using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int>numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userRespose = Console.ReadLine();
            userNumber = int.Parse(userRespose);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // parte 1 

        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"the sum is : {sum}");
        // parte 2 

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // parte 3

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

    }
}