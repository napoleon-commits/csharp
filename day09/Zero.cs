using System;

class Zero
{
    public static void Main()
    {
        Console.WriteLine("Before Exception...");
        throw(new DivideByZeroException());
        Console.WriteLine("After Exception...");
    }
}