using System;
using System.Text;

class Converts
{
    public static void Main()
    {
        string buff;
        int age;

        Console.Write("Enter your age: ");

        buff = Console.ReadLine();

        try
        {
            age = Convert.ToInt32(buff);

            if(age < 21) Console.WriteLine("You are under 21.");
            else Console.Write("You are 21 or older.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("No value was entered... (equal to null)");
        }
        catch (OverflowException)
        {
            Console.WriteLine("You entered a number that is too big or too small");
        }
        catch (FormatException)
        {
            Console.WriteLine("You didn't enter a valid number.");
        }
        catch(Exception e)
        {
            Console.WriteLine("Something went wrong with the conversion.");
            throw(e);
        }
    }
}