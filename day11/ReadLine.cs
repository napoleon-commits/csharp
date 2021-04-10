using System;
using System.Text;

class ReadLine
{
    public static void Main()
    {
        StringBuilder input = new StringBuilder();
        string buff;

        Console.WriteLine("Enter text. When done, press Ctrl+Z");

        while( (buff = Console.ReadLine()) != null)
        {
            input.Append(buff);
            input.Append("\n");
        }

        Console.WriteLine("\n\n================>\n");
        Console.Write(input);
        Console.Write("\n\n");
    }
}