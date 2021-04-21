using System;
using System.Linq;

class Driver
{
    public static void Main()
    {
        string text = (System.IO.File.ReadAllText("./foo.txt"));
        string dateString = String.Join(":", text.Split(':').Skip(1).ToArray()).Trim();
        DateTime dateValue = DateTime.Parse(dateString);
        Console.WriteLine("'{0}' converted to {1}.", dateString, dateValue);
    }
}