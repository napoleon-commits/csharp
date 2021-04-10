using System;

class TryIt
{
    public static void Main()
    {
        int[] myArray = new int[5];

        try
        {
            for(int ctr = 0; ctr < 10; ctr += 1)
            {
                myArray[ctr] = ctr;
            }
        }
        catch
        {
            Console.WriteLine("The exception was caught!");
        }

        Console.WriteLine("At end of class");
    }
}