using System;

class CharsTable
{
    public static void Main()
    {
        char ch1 = 'Z';
        char ch2 = 'x';

        Console.WriteLine("This is the firs line of text");
        Console.WriteLine("\n\n\nSkipped three lines");
        Console.WriteLine("one\ttwo\tthree <- tabbed");
        Console.WriteLine(" A quote: \'  \ndouble quote: \"");
        Console.WriteLine("\n ch1 = {0}     ch2 = {1}", ch1, ch2);
    }
}