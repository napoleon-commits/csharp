using System;

public class Fname
{
    public static void Main()
    {
        char[] name = new char[] {'N', 'a', 'p', 'o', 'l', 'e', 'o', 'n', (char) 0};

        Console.WriteLine("Display content of name array...");

        int ctr = 0;
        while(name[ctr] != 0)
        {
            Console.Write("{0}", name[ctr]);
            ctr += 1;
        }

        Console.WriteLine("\n...Done.");
    }
}