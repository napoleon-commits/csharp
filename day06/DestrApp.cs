using System;

public class Test
{
    static public int sctr = 0;
    public int ctr = 0;

    public void routine()
    {
        Console.WriteLine("In the routine - ctr = {0} / sctr = {1}", ctr, sctr);
    }

    public Test()
    {
        ctr += 1;
        sctr += 1;
        Console.WriteLine("In Contructor");
    }

    ~Test()
    {
        Console.WriteLine("In Desctructor");
    }
}

class DestrApp
{
    public static void Main()
    {
        Console.WriteLine("Start of Main method");

        Test first = new Test();
        Test second = new Test();

        first.routine();

        Test third = new Test();
        third.routine();

        second.routine();

        Console.WriteLine("End of Main method");
    }
}