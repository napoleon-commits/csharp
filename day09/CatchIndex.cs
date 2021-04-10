using System;

class CatchIndex
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
        catch(IndexOutOfRangeException iore)
        {
            Console.WriteLine("You were very goofy trying to use a bad array index!!", iore);
        }
        catch (System.Exception e)
        {
            Console.WriteLine("Exception caught: {0}", e);
        }

        Console.WriteLine("\nDone with the catch statements. DOne with program.");
    }
}