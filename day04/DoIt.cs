class DoIt
{
    public static void Main()
    {
        int ttl = 0;
        int nbr = 0;
        int ctr = 0;

        System.Random rnd = new System.Random();

        do
        {
            nbr = (int) rnd.Next(1,11);
            ctr++;
            ttl += nbr;

            System.Console.WriteLine("Number {0} is {1}", ctr, nbr);
        } while(nbr != 5);

        System.Console.WriteLine("\n{0} numbers were read", ctr);
        System.Console.WriteLine("The total of the numbers is {0}", ttl);
        System.Console.WriteLine("The average of the numbers is {0}", ttl/ctr);
    }
}