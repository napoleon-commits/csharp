using System;

class Picts
{
    public static void Main()
    {
        int var1 = 1234;
        float var2 = 12.34F;

        Console.WriteLine("\nZero...");
        Console.WriteLine("{0} -->{0:0000000}", var1);
        Console.WriteLine("{0} -->{0:0000000}", var2);

        Console.WriteLine("\nSpace...");
        Console.WriteLine("{0} -->{0:0###}<--", var1);
        Console.WriteLine("{0} -->{0:0###}<--", var2);

        Console.WriteLine("\nGroup Multiplier...");
        Console.WriteLine("{0} -->{0:0,,}<--", 1000000);
        Console.WriteLine("Group Separator...");
        Console.WriteLine("{0} -->{0:##,###,##0}<--", 2000000);
        Console.WriteLine("{0} -->{0:##.###.##0}<--", 3);

        Console.WriteLine("\nPercentage...");
        Console.WriteLine("{0} -->{0:0%}<--", var1);
        Console.WriteLine("{0} -->{0:0%}<--", var2);

        Console.WriteLine("\nLiteral Formatting...");
        Console.WriteLine("{0} -->{0: 'My Number: '0}<--", var1);
        Console.WriteLine("{0} -->{0: 'My Number: '0}<--", var2);
        Console.WriteLine("\n{0} -->{0:Mine: 0}<--", var1);
        Console.WriteLine("{0} -->{0:Mine: 0}<--", var2);
    }
}