using System;

class Nbr
{
    public void mathRoutines(double x, out double half, out double squared, out double cubed)
    {
        half = x / 2;
        squared = x * x;
        cubed = x * x * x;
    }
}

class Outter 
{
    public static void Main()
    {
        Nbr doit = new Nbr();

        double nbr = 600;
        double halfNbr, squaredNbr, cubedNbr;
    
        doit.mathRoutines(nbr, out halfNbr, out squaredNbr, out cubedNbr);

        Console.WriteLine("After method -> nbr  = {0}", nbr);
        Console.WriteLine("             halfNbr = {0}", halfNbr);
        Console.WriteLine("          squaredNbr = {0}", squaredNbr);
        Console.WriteLine("            cubedNbr = {0}", cubedNbr);
    }
}