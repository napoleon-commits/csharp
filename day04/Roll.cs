class Roll
{
    public static void Main()
    {
        int roll = 0;

        System.Random rnd = new System.Random();
        roll = (int) rnd.Next(1,7);

        System.Console.WriteLine("Starting the switch... ");

        switch (roll)
        {
            case 1:
                System.Console.WriteLine("Roll is 1");
                break;
            case 2:
                System.Console.WriteLine("Roll is 2");
                break;
            case 3:
                System.Console.WriteLine("Roll is 3");
                break;
            case 4:
                System.Console.WriteLine("Roll is 4");
                break;
            case 5:
                System.Console.WriteLine("Roll is 5");
                break;
            case 6:
                System.Console.WriteLine("Roll is 6");
                break;
            default:
                System.Console.WriteLine("Roll is not 1 through 6");
                break;
        }

        System.Console.WriteLine("The switch statement is now over!");
    }
}