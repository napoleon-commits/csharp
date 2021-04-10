using System;

class MyApp
{
    public static void Main()
    {
        float val = 3.14F;
        object boxed = val;

        float unboxed = (float) boxed;

        Console.WriteLine("val: {0}", val);
        Console.WriteLine("boxed: {0}", boxed);
        Console.WriteLine("unboxed: {0}", unboxed);

        Console.WriteLine("\nTypes...");
        Console.WriteLine("val: {0}", val.GetType());
        Console.WriteLine("boxed: {0}", boxed.GetType());
        Console.WriteLine("unboxed: {0}", unboxed.GetType());
    }
}