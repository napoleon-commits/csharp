using System;

class loco
{
    public int x;

    public void countX()
    {
        int x;
        Console.WriteLine("In countX method. Printing X values...");
        for(x = 0; x <= 10; x+=1)
        {
            Console.Write("{0}  -   ", x);
        }
        Console.WriteLine("\nDone looping.  x = {0}", x);
        Console.WriteLine("The data member x's value: {0}", this.x);
        Console.WriteLine("At the end of countX method.");
    }
}

class LocalsApp
{
    public static void Main()
    {
        loco locals = new loco();
        int x = 999;
        locals.x = 555;
        Console.WriteLine("\nIn Main(), x = {0}", x);
        Console.WriteLine("locals.x = {0}", locals.x);
        Console.WriteLine("Calling Method");
        locals.countX();
        Console.WriteLine("\nBack From Method");
        Console.WriteLine("locals.x = {0}", locals.x);
        Console.WriteLine("In Main(), x = {0}", x);
    }
}