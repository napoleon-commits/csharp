using System;

class Final
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
            Console.WriteLine("Exception caught");
        }
        finally
        {
            Console.WriteLine("Done with exception handling");
        }

        Console.WriteLine("End of Program");
    }
}