using System;

class FormatIt
{
    public static void Main()
    {
        int var = 12345;

        Console.Write("You can format text using Write");
        Console.WriteLine(" and WriteLine. You can insert");
        Console.Write("variables (such as {0}) into a string", var);
        Console.WriteLine(" as well as do other formatting!");
        Console.WriteLine("\n{0:C}\n{0:C4}", var);
        Console.WriteLine("\n{0:f}\n{0:f3}", var);

        string str1 = var.ToString("C");
        string str2 = var.ToString("C3");
        string str3 = var.ToString("E8");

        Console.WriteLine("\nYou can also format using ToString");
        Console.WriteLine(str1);
        Console.WriteLine(str2);
        Console.WriteLine(str3);

        string str4 = string.Format("\nOr, you can use string.Format: ");
        string str5 = string.Format("Nbr {0:F3} \n{0:C} \n{0:C0}", var);

        Console.WriteLine(str4);
        Console.WriteLine(str5);
    }
}