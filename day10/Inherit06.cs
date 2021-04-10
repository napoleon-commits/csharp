using System;

sealed public class Number
{
    private float pi;

    public Number()
    {
        pi = 3.14159F;
    }

    public float PI
    {
        get{return pi;}
    }
}

class MyApp
{
    public static void Main()
    {
        Number myNumbers = new Number();
        Console.WriteLine("PI = {0}", myNumbers.PI);
    }
}