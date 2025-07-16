using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetTopNumber());
        Console.WriteLine(f1.GetBottomNumber());
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalvalue());

        Fraction f2 = new Fraction(7);
        f2.SetBottomNumber(3);
        Console.WriteLine(f2.GetTopNumber());
        Console.WriteLine(f2.GetBottomNumber());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalvalue());

        Fraction f3 = new Fraction(5, 7);
        Console.WriteLine(f3.GetTopNumber());
        Console.WriteLine(f3.GetBottomNumber());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalvalue());

        Fraction f4 = new Fraction();
        f4.SetTopNumber(16);
        f4.SetBottomNumber(8);
        Console.WriteLine(f4.GetTopNumber());
        Console.WriteLine(f4.GetBottomNumber());
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalvalue());
    }
}