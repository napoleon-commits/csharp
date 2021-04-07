class And
{
    public static void Main()
    {
        int day = 1;
        char sex = 'f';

        System.Console.WriteLine("Starting test... (day:{0}, sex:{1})", day, sex);

        if(day >= 1 && day <= 7)
        {
            System.Console.WriteLine("Day is from 1 to 7");
        }
        if(sex == 'm' || sex == 'f')
        {
            System.Console.WriteLine("Sex is male or female");
        }

        System.Console.WriteLine("Done with the checks.");
    }
}