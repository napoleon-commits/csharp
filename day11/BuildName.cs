using System;
using System.Text;

class BuildName
{
    public static void Main()
    {
        StringBuilder name = new StringBuilder();
        string buffer;
        int marker = 0;

        Console.Write("\nEnter your first name: ");
        buffer = Console.ReadLine();

        if(buffer != null)
        {
            name.Append(buffer);
            marker = name.Length;
        }

        Console.Write("\nEnte your last name: ");
        buffer = Console.ReadLine();

        if(buffer != null)
        {
            name.Append(" ");
            name.Append(buffer);
        }

        Console.Write("\nEnter your middle name: ");
        buffer = Console.ReadLine();

        if(buffer != null)
        {
            name.Insert(marker+1, buffer);
            name.Insert(marker+buffer.Length+1, " ");
        }

        Console.WriteLine("\n\nFull name: {0}", name);

        Console.WriteLine("\n\nInfo about StringBuilder string:");
        Console.WriteLine("value: {0}", name);
        Console.WriteLine("Capactity: {0}", name.Capacity);
        Console.WriteLine("Maximum Capactity: {0}", name.MaxCapacity);
        Console.WriteLine("Length: {0}", name.Length);
    }
}