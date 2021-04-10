using System;

public class Names
{
    public static void Main()
    {
        char[][] name = new char[3][];

        name[0] = new char[8] {'N','a','p','o','l','e','o','n'};
        name[1] = new char[2] {'d','i',};
        name[2] = new char[9] {'B','o','n','a','p','a','r','t','e'};

        Console.WriteLine("Display the sizes of the array...\n");

        Console.WriteLine("Length of name array {0}", name.Length);

        for(int ctr = 0; ctr < name.Length; ctr += 1)
        {
            Console.WriteLine("Length of name[{0}] is {1}", ctr, name[ctr].Length);
        }

        Console.WriteLine("\nDisplaying the content of the name array...");

        for(int ctr = 0; ctr < name.Length; ctr += 1)
        {
            Console.Write("\n");
            for(int ctr2 = 0; ctr2 < name[ctr].Length; ctr2 += 1)
            {
                Console.Write("{0}", name[ctr][ctr2]);
            }
        }

        Console.WriteLine("\n...Done displaying");
    }
}