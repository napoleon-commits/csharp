using System;

class Scope
{
    public static void Main()
    {
        // for(int x; x < 10; x +=1)
        for(int x = 0; x < 10; x +=1)
        {
            Console.WriteLine("x is {0}", x);
        }

        // Console.WriteLine("Out of For Loop. x is {0}", x);
    }
}