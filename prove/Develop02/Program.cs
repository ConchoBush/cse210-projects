using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        // Class options for prompts to use in journal questions to guide user in journaling. 
        Option option1 = new Option();
        option1._prompts = 1;
        option1._description = "What was one thing you would choose to do differently today?";

        Option option2 = new Option();
        option2._prompts = 2;
        option2._description = "What was your favorite thing you did today?";

        Option option3 = new Option();
        option3._prompts = 3;
        option3._description = "What was the best part of your day?";

        Option option4 = new Option();
        option4._prompts = 4;
        option4._description = "How did you try to help someone today?";

        Option option5 = new Option();
        option5._prompts = 5;
        option5._description = "How did you feel the help of Jesus Christ today?";
        
        
        // Opening text in console for the program.
        Console.WriteLine("Welcome to the Journal Program!");
        // while loop to keep the program from closing after inputing information. 
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            string userInput = Console.ReadLine();
            choice = int.Parse(userInput);
            
            //Create if statment for determing choice
            //Choice 1. Prompt user with random question.  Write answer into a list with datetime by creating new class entry.
            if (choice == 1)
            {
                Console.WriteLine("You chose choice 1.");
            }
            //Choice 2. Display current loaded list from prompt 1.  If list is empty, display "you have not journaled anything yet".
            else if (choice == 2)
            {
                Console.WriteLine("You chose choice 2.");
            }
                
            //Choice 3. Load .txt file for user to continue writing in journal with. 
            else if (choice == 3)
            {
                Console.WriteLine("You chose choice 3.");
            }
            //Choice 4. Append current journal list to save .txt file.  
            else if (choice == 4)
            {
                Console.WriteLine("You chose choice 4.");
            }
            //Choice 5. Prompt user if they would like to save. Y/N if Yes run save /choice 4 script, then quit.  If no, end program.
            else if (choice == 5)
            {
                Console.WriteLine("You chose choice 5.");
            }
            else
            {
                Console.WriteLine("That is not a valid choice.");
            }
        }
    }
}

