using System;

class DtFormat
{
    public static void Main()
    {
        DateTime currTime = DateTime.Now;

        Console.WriteLine("d: {0:d}", currTime);
        Console.WriteLine("D: {0:D}", currTime);
        Console.WriteLine("f: {0:f}", currTime);
        Console.WriteLine("F: {0:F}", currTime);
        Console.WriteLine("g: {0:g}", currTime);
        Console.WriteLine("G: {0:G}", currTime);
        Console.WriteLine("m: {0:m}", currTime);
        Console.WriteLine("M: {0:M}", currTime);
        Console.WriteLine("r: {0:r}", currTime);
        Console.WriteLine("R: {0:R}", currTime);
        Console.WriteLine("s: {0:s}", currTime);
        Console.WriteLine("t: {0:t}", currTime);
        Console.WriteLine("T: {0:T}", currTime);
        Console.WriteLine("u: {0:u}", currTime);
        Console.WriteLine("U: {0:U}", currTime);
        Console.WriteLine("y: {0:y}", currTime);
        Console.WriteLine("Y: {0:Y}", currTime);
    }
}