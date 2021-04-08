class Stacked
{
    static void Main()
    {
        char gender = 'x';

        if(gender == 'm')
        {
            System.Console.WriteLine("The gender is male");
        }
        else if (gender == 'f')
        {
            System.Console.WriteLine("The gender is female");
        }
        else
        {
            System.Console.WriteLine("The gender value, {0}, is not valid", gender);
        }
        System.Console.WriteLine("The if statement is now over!");
    }
}