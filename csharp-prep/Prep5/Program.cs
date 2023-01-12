using System;

class Program
{
    static void Main(string[] args)
    
    {
        DisplayMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }   
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        int number;
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        number = int.Parse(input);
        return number;

    }
    static int SquareNumber(int number)
    {
        int squared = number * number;
        squared = number * number;
        return squared;
    }
    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }
        
       
    
    }
}