using System;

class General
{
    public static void Main()
    {
        float fVal1 = 0.000000789F;
        float fVal2 = 1.2F;

        Console.WriteLine("f1   ({0:f}). Format (G): {0:G}", fVal1);
        Console.WriteLine("f2   ({0:f}). Format (G): {0:G}", fVal2);
    }
}