class IfElse
{
    public static void Main()
    {
        char gender = 'x';

        if(gender == 'm' || gender == 'f')
        {
            System.Console.WriteLine("The gender is valid");
        }
        else
        {
            System.Console.WriteLine("The gender value, {0}, is not valid", gender);
        }
        System.Console.WriteLine("The if statement is now over!");
    }
}