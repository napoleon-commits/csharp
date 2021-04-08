class Average
{
    public static void Main()
    {
        int ttl = 0;
        int nbr = 0;
        int ctr = 0;

        System.Random rnd = new System.Random();

        for(ctr = 1; ctr <= 10; ctr++)
        {
            nbr = (int) rnd.Next(1,11);

            System.Console.WriteLine("Number {0} is {1}", (ctr), nbr);

            ttl += nbr;
        }

        System.Console.WriteLine("\nThe total of the 10 numbers is {0}", ttl);
        System.Console.WriteLine("\nThe average of the numbers is {0}",ttl/10);
    }
}