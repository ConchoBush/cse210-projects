using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        int r = grade % 10;
        string sign = "";
        if (r <= 3)
        {
            sign = "-";
        }
        else if (r >= 7)
        {
            sign = "+";
        }
        else 
        {
            sign = "";
        }
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        } 
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        if (letter == "A" && sign == "+" || letter == "F")
        {
            sign = "";
        }
            Console.WriteLine($"Your grade is: {letter}{sign} ");
        
            
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you passed the course!");
        }
        else
        {
            Console.WriteLine("I am sorry, you did not pass the course. You will do better next time I know it!");
        }
           

    }
}