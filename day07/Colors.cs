using System;

class Colors
{
    enum Color
    {
        red,
        white,
        blue,
    }

    public static void Main()
    {
        string buffer;
        Color myColor;

        Console.Write("Enter a value for a color: 0 = Red, 1 = White, 2 = Blue:     ");
        buffer = Console.ReadLine();

        myColor = (Color) Convert.ToInt32(buffer);

        switch(myColor)
        {
            case Color.red:
                System.Console.WriteLine("\nSwitched to Red...");
                break;
            case Color.white:
                System.Console.WriteLine("\nSwitched to White...");
                break;
            case Color.blue:
                System.Console.WriteLine("\nSwitched to Blue...");
                break;
            default:
                System.Console.WriteLine("\nSwitched to default...");
                break;
        }

        System.Console.WriteLine("\nColor is {0}    ({1})", myColor, (int) myColor);
    }
}