using System;

public class Balances
{
    public static void Main()
    {
        decimal[] balances = new decimal[12];

        decimal ttl = 0m;

        System.Random rnd = new System.Random();

        for(int index = 0; index < 12; index += 1)
        {
            balances[index] = (decimal) (rnd.NextDouble() * 10000);
        }

        for(int index = 0; index < 12; index += 1)
        {
            Console.WriteLine("Balance {0}: {1}", index, balances[index]);
            ttl += balances[index];
        }

        Console.WriteLine("=============================");
        Console.WriteLine("Total of Balances = {0}", ttl);
        Console.WriteLine("Average Balance = {0}", (ttl/12));
    }
}