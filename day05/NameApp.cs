using System;

class Name
{
    public string first;
    public string last;
}

class NameApp
{
    public static void Main()
    {
        Name you = new Name();

        Console.WriteLine("Enter your first name and press enter: ");
        you.first = Console.ReadLine();

        Console.Write("\n{0}, enter your last name and press enter: ", you.first);

        you.last = Console.ReadLine();

        Console.WriteLine("\nData has been entered.....");

        System.Console.WriteLine("You claim to be {0} {1}", you.first, you.last);
    }
}