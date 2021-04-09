using System;

class Multiply
{
    static public long multi(long nbr1, long nbr2)
    {
        return (nbr1 * nbr2);
    }
}

public class MultiApp
{
    public static void Main()
    {
        long x = 1234;
        long y = 5678;
        long a = 6789;
        long b = 9876;

        long result;

        result = Multiply.multi(x, y);
        Console.WriteLine("x * y : {0} * {1} = {2}", x, y, result);

        result = Multiply.multi(a, b);
        Console.WriteLine("a * b : {0} * {1} = {2}", a, b, result);

        result = Multiply.multi(555L, y=1000L);
        Console.WriteLine("With Long values passed, result is {0}", result);
    }
}