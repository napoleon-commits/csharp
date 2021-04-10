using System;
using System.Text;

class ReadIt
{
    public static void Main()
    {
        StringBuilder input = new StringBuilder();

        int ival;
        char ch = ' ';

        Console.WriteLine("Enter text. When done, press CTRL+Z:");

        while(true)
        {
            ival = Console.Read();
            if(ival == -1) break;
            ch = (char) ival;

            input.Append(ch);
        }

        Console.WriteLine("\n\n==============>\n");
        Console.Write(input);
        Console.Write("\n\n");
    }
}