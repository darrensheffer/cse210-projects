using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int>();
       int userNumber = -5;
       
       Console.WriteLine("Enter a list of numbers, type 0 when finished.");
       
       while (userNumber != 0)
       {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sumTotal = 0;

        foreach (int number in numbers)
        {
            sumTotal += number;
        }

        Console.WriteLine($"The sum is: {sumTotal}");
        float average = ((float)sumTotal) / numbers.Count;

        Console.WriteLine($"The average is the: {average}");

        int largestNumber = 0;
        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }

        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}