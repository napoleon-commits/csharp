// csc /r:Calc.dll MyApp.cs


using System;

public class MyApp
{
    public static void Main()
    {
        Console.WriteLine("Using Calc component");
        Console.WriteLine("Calc.Add(33,11); = {0}", Calc.Add(33,11));
        Console.WriteLine("Calc.Subtract(33,11); = {0}", Calc.Subtract(33,11));
    }
}