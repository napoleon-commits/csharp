using System;

class MyThreeException : Exception {}

class MathApp
{
    public static void Main()
    {
        int result;
        try
        {
            result = MyMath.AddEm(1,2);
            Console.WriteLine("Result of AddEm(1,2) is {0}", result);
            result = MyMath.AddEm(3,4);
            Console.WriteLine("Result of AddEm(3,4) is {0}", result);
        }
        catch (MyThreeException)
        {
            Console.WriteLine("Ack!     We don't like adding threes.");
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception caught: {0}", e);
        }
        Console.WriteLine("\nAt end of program");
    }
}

class MyMath
{
    static public int AddEm(int x, int y)
    {
        if(x == 3 || y == 3)
        {
            throw new MyThreeException();
        }
        return x + y;
    }
}