using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? (example: 87): ");
        string userInput = Console.ReadLine();
        int userGrade = int.Parse(userInput);
    
        string grade = "";
        string sign = "";
        
        int signMath = userGrade % 10;

        if (signMath >= 7)
        {
            sign = "+";
        }

        else if (signMath <= 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }

        if (userGrade >= 90 && userGrade <= 100)
        {
            grade = "A";
        }
        
        else if (userGrade >= 80 && userGrade < 90)
        {
            grade = "B";
        }

        else if (userGrade >= 70 && userGrade < 80)
        {
           grade = "C";
        }

        else if (userGrade >= 60 && userGrade < 70)
        {
            grade = "D";
        } 

        else if (userGrade > 60)
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}{sign}.");

        if (userGrade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }

        else if(userGrade < 70)
        {
            Console.WriteLine("So Close! Better luck next time!");
        }
    }
}