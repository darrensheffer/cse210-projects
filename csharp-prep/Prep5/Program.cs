using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int Square = SquareNumber(userNumber);

        DisplayResults(userName, Square);
    }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            return userNumber;
        }

        static int SquareNumber(int userNumber)
        {
            int SquareNumber = userNumber * userNumber;
            return SquareNumber;
        }

        static void DisplayResults(string userName, int SquareNumber)
        {
            Console.WriteLine($"{userName}, The square of your number is {SquareNumber}.");
        }
}