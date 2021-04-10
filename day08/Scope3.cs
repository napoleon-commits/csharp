using System;

class Scope3
{
    static int x = 987;

    public static void Main()
    {
        Console.WriteLine("x is {0}", x);

        // for(int x = 1; x < 5; x+=1)
        // {
        //     Console.WriteLine("x is {0}", x);
        // }

        Console.WriteLine("x is {0}", x);
    }
}