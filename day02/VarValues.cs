using System;

class VarValues
{
    public static void Main()
    {
        int firstVar;
        int secondVar = 200;
        firstVar = 5;
        Console.WriteLine("\nfirstVar contains the value {0}", firstVar);
        Console.WriteLine("secondVar contains the value {0}", secondVar);

        firstVar = 1010;
        secondVar = 2020;
        Console.WriteLine("\nfirstVar contains the value {0}", firstVar);
        Console.WriteLine("secondVar contains the value {0}", secondVar);
    }
}