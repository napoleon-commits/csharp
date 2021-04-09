using System;

public class Test
{
    static public int sctr;
    public int ctr;

    public void routine()
    {
        Console.WriteLine("In the routing - ctr = {0} / sctr = {1}\n", ctr, sctr);
    }

    static Test()
    {
        sctr = 100;
        Console.WriteLine("In Static Constructor - sctr = {0}\n", sctr);
    }

    public Test()
    {
        ctr += 1;
        sctr += 1;
        Console.WriteLine("In Constructor - ctr = {0} / sctr = {1}\n", ctr, sctr);
    }
}

class StatCon
{
    public static void Main()
    {
        Console.WriteLine("Start of Main method...");

        Console.WriteLine("Creating first object...");
        Test first = new Test();
        Console.WriteLine("Creating second object...");
        Test second = new Test();

        Console.WriteLine("Calling first routine...");
        first.routine();

        Console.WriteLine("Creating third object...");
        Test third = new Test();
        Console.WriteLine("Calling third routine...");
        third.routine();

        Console.WriteLine("Calling second routine...");
        second.routine();

        Console.WriteLine("End of Main method");
    }
}