using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Steven", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math1 = new MathAssignment("Layton", "Fractions", "7.3", "8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment writing1 = new WritingAssignment("Natalie", "European History", "The Causes of World War II ");
       
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());

    }
}