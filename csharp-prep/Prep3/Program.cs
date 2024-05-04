using System;

class Program
{
    static void Main(string[] args)
    {
        int tally = 0;
        int guess = 0;
        String userInput = "yes";

        while (userInput == "yes")
        {
            // Console.Write("What is the magic number? ");
            // String userMagicNumber = Console.ReadLine();
            // int magicNumber = int.Parse(userMagicNumber);

            Random random= new Random();
            int magicNumber = random.Next(1, 100);
            
            Console.WriteLine("Can you guess the random number between 1 and 100?");
            
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                String userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);
                tally++;  
            

                if (guess == magicNumber)
                {
                    Console.WriteLine($"You guessed it in {tally} guesses");
                }

                else if (guess <= magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else if (guess >= magicNumber)
                {
                    Console.WriteLine("Lower");
                }
            }
            
            Console.Write("Would you like to play again? ");
            userInput = Console.ReadLine().ToLower();
        }
    }
}