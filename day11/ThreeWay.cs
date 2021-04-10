using System;

class ThreeWay
{
    public static void Main()
    {
        Console.WriteLine("\nExample 1...");
        for(int x = -100; x <= 100; x += 100)
        {
            Console.WriteLine("{0:000;-00000;'0'}", x);
        }

        Console.WriteLine("\nExample 2...");
        for(int x = -100; x <= 100; x += 100)
        {
            Console.WriteLine("{0:Pos: 0;Neg: -0;Zero}", x);
        }

        Console.WriteLine("\nExample 3...");
        for(int x = -100; x <= 100; x += 100)
        {
            Console.WriteLine("{0:You Win!;You Lose!;You Broke Even!}", x);
        }
    }
}