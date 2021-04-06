using System;

class App
{
    public static void Main()
    {
        int radius = 4;
        const double PI = 3.14159;
        double area;

        area = PI * radius * radius;

        Console.WriteLine("Radius = {0}, PI = {1}", radius, PI);
        Console.WriteLine("The area is {0}", area);
    }
}