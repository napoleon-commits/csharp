using System;

public class MyClass
{
    static public int sctr = 0;
    public int ctr = 0;

    public void routine()
    {
        Console.WriteLine("In the routing - ctr = {0} / sctr = {1}\n", ctr, sctr);
    }

    public MyClass()
    {
        ctr += 1;
        sctr += 1;
        Console.WriteLine("In Constructor ctr = {0} / sctr = {1}\n", ctr, sctr);
    }
}

class TestApp
{
    public static void Main()
    {
        Console.WriteLine("Start of Main method...");
        Console.WriteLine("Creating first object...");
        MyClass first = new MyClass();

        Console.WriteLine("Creating second object...");
        MyClass second = new MyClass();

        Console.WriteLine("Calling first routing...");
        first.routine();

        Console.WriteLine("Creating third object...");
        MyClass third = new MyClass();
        Console.WriteLine("Calling third routine...");
        third.routine();

        Console.WriteLine("Calling second routine...");
        second.routine();

        Console.WriteLine("End of Main method");
    }
}