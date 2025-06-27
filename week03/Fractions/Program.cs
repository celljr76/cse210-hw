using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fractions _fractions1 = new Fractions();
        Fractions _fractions2 = new Fractions();
        Fractions _fractions3 = new Fractions();
        Fractions _fractions4 = new Fractions();

        _fractions1.SetTop(1);
        _fractions1.GetTop();
        _fractions1.SetBottom(1);
        _fractions1.GetBottom();
        _fractions2.SetTop(5);
        _fractions2.GetTop();
        _fractions2.SetBottom(1);
        _fractions2.GetBottom();
        _fractions3.SetTop(3);
        _fractions3.GetTop();
        _fractions3.SetBottom(4);
        _fractions3.GetBottom();
        _fractions4.SetTop(1);
        _fractions4.GetTop();
        _fractions4.SetBottom(3);
        _fractions4.GetBottom();
        Console.WriteLine(_fractions1.GetFractionString());
        Console.WriteLine(_fractions1.GetDecimal());
        Console.WriteLine(_fractions2.GetFractionString());
        Console.WriteLine(_fractions2.GetDecimal());
        Console.WriteLine(_fractions3.GetFractionString());
        Console.WriteLine(_fractions3.GetDecimal());
        Console.WriteLine(_fractions4.GetFractionString());
        Console.WriteLine(_fractions4.GetDecimal());
       


    }
}