using System;

class Sizes
{
    unsafe public static void Main()
    {
        Console.WriteLine( "\nA byte        is {0} byte(s)", sizeof(byte));
        Console.WriteLine( "\nA sbyte       is {0} byte(s)", sizeof(sbyte));
        Console.WriteLine( "\nA char        is {0} byte(s)", sizeof(char));
        Console.WriteLine( "\nA short       is {0} byte(s)", sizeof(short));
        Console.WriteLine( "\nA ushort      is {0} byte(s)", sizeof(ushort));
        Console.WriteLine( "\nA int         is {0} byte(s)", sizeof(int));
        Console.WriteLine( "\nA uint        is {0} byte(s)", sizeof(uint));
        Console.WriteLine( "\nA long        is {0} byte(s)", sizeof(long));
        Console.WriteLine( "\nA ulong       is {0} byte(s)", sizeof(ulong));
        Console.WriteLine( "\nA float       is {0} byte(s)", sizeof(float));
        Console.WriteLine( "\nA double      is {0} byte(s)", sizeof(double));
        Console.WriteLine( "\nA decimal     is {0} byte(s)", sizeof(decimal));
        Console.WriteLine( "\nA bool        is {0} byte(s)", sizeof(bool));
    }
}