using System;

class CommandLine
{
    public static void Main(string[] args)
    {
        int ctr = 0;
        if(args.Length <= 0)
        {
            Console.WriteLine("No Command Line arguments were provided.");
            return;
        }
        else
        {
            for(ctr = 0; ctr < args.Length; ctr +=1)
            {
                Console.WriteLine("Argument {0} is {1}", ctr + 1, args[ctr]);
            }
        }
    }
}