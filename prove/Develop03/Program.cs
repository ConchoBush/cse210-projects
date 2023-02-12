using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        
        //Create scripture references.
        Reference r1 = new Reference("3rd Nephi", 12, 3, 3);
        Scripture s1 = new Scripture("Yea blessed are the poor in spirit who come unto me for theirs is the kingdom of heaven.");
        Reference r2 = new Reference("Proverbs", 3, 5, 6);
        Scripture s2 = new Scripture("Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        //main section of program.  Build the welcome screen for scripture memorization. 
        //added the ability for user to provide their own scripture to study. 
        
        Console.WriteLine("Hello, Welcome to Scripture Memorization Headquarters!");
        Console.WriteLine("Would you like a random Scripture today or to type in your own?");
        Console.WriteLine("1. Random Scripture");
        Console.WriteLine("2. Provide Scripture");
        Console.WriteLine("3. Quit");
        string userInput = Console.ReadLine();
        int choice = int.Parse(userInput);

        if (choice == 1)
        {
            //randomly choose a scripture to load
            Random rnd = new Random();
            int num = rnd.Next(2);
            if (num == 1)
            {
            Console.WriteLine(hider(r1.GetReference() + s1.GetScripture()));
            }
            else
            {
            Console.WriteLine(hider(r2.GetReference() + s2.GetScripture()));
            }
        }
        
        else if (choice == 2)
        {
            Console.WriteLine("Please provide the reference and scripture text.");
            String d = Console.ReadLine();
            //call function for scripture memorization 
            Console.WriteLine(hider(d));
        }

        else if (choice == 3)
        {
            Console.WriteLine("GoodBye");
        }
        else
        {
            Console.WriteLine("That was not a valid choice, ending program");
        }
        //Hide words after pressing enter
        static String hider(String text)
        {
        Random ran = new Random();
        string [] wordList = text.Split(' ');
        string result = "";
        string hide = "_";
        Console.Clear();
        string word = wordList[ran.Next(0, wordList.Length)];
        for (int i = 1; i < word.Length; i++)
            hide += '_';
        int index = 0;
        foreach (string i in wordList)
    {
        if (i.CompareTo(word) == 0)
        wordList[index] = hide;
        index++;
    }
        foreach (String i in wordList)
            result += i + " ";
                return result;
                string again = result;    
        //I dont know how to get this loop to work.  I tried while and other ways, but I am struggling and I spend 20+ hours on this program to fail at it. 
         Console.WriteLine("Press Enter to hide text or type 'Quit' to finish");  
                string con = Console.ReadLine();
                if (con == "Quit")
                {
                    Console.WriteLine("Have a great day!");
                } 
                else
                {
                    Console.WriteLine(hider(again));
                }
        }
    }
    

    
}
