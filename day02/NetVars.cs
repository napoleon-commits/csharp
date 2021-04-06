using System;

class NetVars
{
    public static void Main()
    {
        System.Int32 myVariable = 4;
        System.Double PI = 3.14159;
        System.Double area = PI * myVariable * myVariable;

        Console.WriteLine("\nmyVariable is {0}", myVariable);
        Console.WriteLine("\nPI is {0}", PI);
        Console.WriteLine("\nArea is {0}", area);
    }
}