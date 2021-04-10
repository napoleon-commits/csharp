using System;

public class Garbage
{
    public static void Print(params object[] args)
    {
        int ctr = 0;

        for(ctr = 0; ctr < args.Length; ctr += 1)
        {
            Console.WriteLine("Argument {0} is:     {1}", ctr, args[ctr]);
        }
    }
}

class MyApp
{
    public static void Main()
    {
        long aLong = 1234567890987654321L;
        decimal aDec = 1234.56M;
        byte aByte = 42;
        string aString = "Colm O'Driscoll";

        Console.WriteLine("First call...");
        Garbage.Print(1);

        Console.WriteLine("\nSecond call...");
        Garbage.Print();

        Console.WriteLine("\nThird call...");
        Garbage.Print(aLong, aDec, aByte, aString);

        Console.WriteLine("\nForth call...");
        Garbage.Print(aString, "is cool", '!');
    }
}