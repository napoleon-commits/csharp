using System;

class Scope2
{
    public static void Main()
    {
        for(int x = 1; x < 5; x += 1)
        {
            Console.WriteLine("x is {0}", x);
        }

        for(int x = 1; x < 5; x +=1)
        {
            Console.WriteLine("x is {0}", x);
        }
    }
}