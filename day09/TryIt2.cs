using System;

class TryIt2
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
        catch (System.Exception e)
        {
            Console.WriteLine("The following exception was caught:\n{0}", e);
        }

        Console.WriteLine("At end of class");
    }
}