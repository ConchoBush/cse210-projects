using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(6);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Fraction f2 = new Fraction(6, 7);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Fraction f3 = new Fraction();
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Fraction f4 = new Fraction(7,21);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
        Fraction f5 = new Fraction(7, 8);
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());
        Fraction f6 = new Fraction(5, 10);
        Console.WriteLine(f6.GetFractionString());
        Console.WriteLine(f6.GetDecimalValue());
        Fraction f7 = new Fraction(27);
        Console.WriteLine(f7.GetFractionString());
        Console.WriteLine(f7.GetDecimalValue());
    }
}