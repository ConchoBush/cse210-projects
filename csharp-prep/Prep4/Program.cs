using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int a;
        int total = 0;
        

        Console.WriteLine("Ener a list of numbers, type 0 when finished.");
        do
        {
        Console.Write("Enter Number: ");
        string userInput = Console.ReadLine();
        a = int.Parse(userInput);
        if (a !=0)
        {
        numbers.Add(a);
        }
        total = total + a;


        } while (a != 0);
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max<int>()}");
        Console.WriteLine($"The smallest number is: {numbers.Min<int>()}");
        Console.WriteLine($"The smallest positive number is: {numbers.Where(x => x >= 0).Min()}");
        numbers.Sort();
        foreach (int i in numbers)
        {
        Console.WriteLine(i);
        }

    }
}