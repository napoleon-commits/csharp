using System;

public class ForEach1
{
    public static void Main()
    {
        char[] name = new char[] {'N','a','p','o','l','e','o','n'};

        Console.WriteLine("Display content of name array...");

        foreach(char x in name)
        {
            Console.Write("{0}", x);
        }

        Console.WriteLine("\n...Done");
    }
}