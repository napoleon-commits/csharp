using System;

class Colors2
{
    enum Color : byte
    {
        red, white, blue,
    }

    public static void Main()
    {
        Color myColor;
        byte roll;

        System.Random rnd = new System.Random();

        for(int ctr = 0; ctr < 10; ctr += 1)
        {
            roll = (byte) (rnd.Next(0,3));
            myColor = (Color) roll;

            System.Console.WriteLine("Color is {0} ({1} of type {2})", myColor, (byte) myColor, myColor.GetTypeCode());
        }
    }
}