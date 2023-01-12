using System;

class Program
{
    static void Main(string[] args)
    {
        string input;
        do
        {
        Console.WriteLine("Welcome to the Guess The Magic Number Game.");
        Console.WriteLine("Please guess a number between 1 and 100.");
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);
        int guess = 0;
        int total = 1;
        do
        {
        Console.WriteLine("What is your guess? ");
        string userInput = Console.ReadLine();
        guess = int.Parse(userInput);
        if (guess < magic)
        {
            Console.WriteLine("Higher");
            total = total + 1;
        }
        else if (guess > magic)
        {
            Console.WriteLine("Lower");
            total = total + 1;
        }
        else 
        {
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {total} guesses. ");
        }
        } while (guess != magic);
        Console.WriteLine("Do you want to play again?");
        input = Console.ReadLine();
    
        } while (input == "yes");
    }
}