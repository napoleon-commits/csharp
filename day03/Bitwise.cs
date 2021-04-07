class Bitwise
{
    public static void Main()
    {
        int valOne = 1;
        int valZero = 0;
        int newVal;

        newVal = valZero ^ valZero;
        System.Console.WriteLine("\nThe XOR Operator: \n0 ^ 0 = {0}", newVal);
        newVal = valZero ^ valOne;
        System.Console.WriteLine("0 ^ 1 = {0}", newVal);
        newVal = valOne ^ valZero;
        System.Console.WriteLine("1 ^ 0 = {0}", newVal);
        newVal = valOne ^ valOne;
        System.Console.WriteLine("1 ^ 1 = {0}", newVal);
        
        newVal = valZero & valZero;
        System.Console.WriteLine("\nThe AND Operator: \n0 & 0 = {0}", newVal);
        newVal = valZero & valOne;
        System.Console.WriteLine("0 & 1 = {0}", newVal);
        newVal = valOne & valZero;
        System.Console.WriteLine("1 & 0 = {0}", newVal);
        newVal = valOne & valOne;
        System.Console.WriteLine("1 & 1 = {0}", newVal);

        newVal = valZero | valZero;
        System.Console.WriteLine("\nThe OR Operator: \n0 | 0 = {0}", newVal);
        newVal = valZero | valOne;
        System.Console.WriteLine("0 | 1 = {0}", newVal);
        newVal = valOne | valZero;
        System.Console.WriteLine("1 | 0 = {0}", newVal);
        newVal = valOne | valOne;
        System.Console.WriteLine("1 | 1 = {0}", newVal);

    }
}