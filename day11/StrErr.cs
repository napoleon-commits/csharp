using System;

class StrErr
{
    public static void Main()
    {
        string str1 = "abcdefghijklmnop";

        try
        {
            // str1[5] = 'X';
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }

        Console.WriteLine(str1);
    }
}