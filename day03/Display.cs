class Display
{
    public static void Main()
    {
        int iNbr = 321;
        double dNbr = 123.45;

        System.Console.WriteLine("First WriteLine Line");
        System.Console.WriteLine("Second WriteLine Line");

        System.Console.Write("First Write Line");
        System.Console.Write("Second Write Line");

        System.Console.WriteLine("\nWriteLine: Parameter = {0}", 123);
        System.Console.Write("Write: Parameter = {0}", 456);
        
        System.Console.WriteLine("\nWriteLine: val1 = {0} val2 = {1}", iNbr, dNbr);
        System.Console.Write("Write: val1 = {0} val2 = {1}", iNbr, dNbr);
    }
}