class Average
{
    public static void Main()
    {
        int ttl = 0;
        int nbr = 0;
        int ctr = 0;

        System.Random rnd = new System.Random();

        while (ctr < 10)
        {
            nbr = (int) rnd.Next(1, 11);

            System.Console.WriteLine("Number {0} is {1}", (ctr+1), nbr);

            ttl += nbr;
            ctr++;
        }

        System.Console.WriteLine("\nThe total of the {0} numbers is {1}", ctr, ttl);

        System.Console.WriteLine("\nThe average of the numbers is {0}", ttl/ctr);
    }
}