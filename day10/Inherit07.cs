using System;

sealed class PI
{
    public static float nbr;

    static PI()
    {
        nbr = 3.14159F;
    }

    static public float val()
    {
        return nbr;
    }
}

class MyApp
{
    public static void Main()
    {
        Console.WriteLine("PI = {0}", PI.val());

        Object x = new PI();
        Console.WriteLine("ToString: {0}", x.ToString());
        Console.WriteLine("Type: {0}", x.GetType());
        Console.WriteLine("ToString: {0}", 123.ToString());
        Console.WriteLine("Type: {0}", 123.GetType());
    }
}