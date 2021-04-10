using System;

public class AddEm
{
    public static long Add(params int[] args)
    {
        int ctr = 0;
        long total = 0;

        for(ctr = 0; ctr < args.Length; ctr += 1)
        {
            total += args[ctr];
        }
        return total;
    }
}

class MyApp
{
    public static void Main()
    {
        long total = 0;

        total = AddEm.Add(1);
        Console.WriteLine("Total of (1) = {0}", total);

        total = AddEm.Add(1,2);
        Console.WriteLine("Total of (1,2) = {0}", total);

        total = AddEm.Add(1,2,3);
        Console.WriteLine("Total of (1,2,3) = {0}", total);

        total = AddEm.Add(1,2,3,4);
        Console.WriteLine("Total of (1,2,3,4) = {0}", total);
    }
}