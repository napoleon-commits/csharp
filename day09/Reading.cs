#define DEBUG

using System;
using System.IO;

public class Reading
{
    public static void Main(String[] args)
    {
        if(args.Length < 1)
        {
            Console.WriteLine("Must include file name.");
        }
        else
        {
#if DEBUG

            Console.WriteLine("=======================DEBUG INFO====================");
            for(int x = 0; x < args.Length; x += 1)
            {
                Console.WriteLine("Arg[{0}] = {1}", x, args[x]);
            }
            Console.WriteLine("=====================================================");

#endif

            string buffer;

            StreamReader myFile = File.OpenText(args[0]);

            while((buffer = myFile.ReadLine()) != null)
            {
#if DEBUG
                Console.Write("{0:D3} - ", buffer.Length);
#endif
                Console.WriteLine(buffer);
            }

            myFile.Close();
        }
    }
}