#define DEBUG
#define BOOKCHECK

#if DEBUG
    #warning Compiled listing in Debug Mode
#endif
#if BOOKCHECK
    #warning Compiled listing with Book Check on
#endif
#if DEBUG && PRODUCTION
    #error Compiled with both DEBUG and PRODUCTION!
#endif

using System;
using System.IO;

public class Reading2
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
            Console.WriteLine("====================DEBUG INFO=====================");
            for(int x = 0; x < args.Length; x += 1)
            {
                Console.WriteLine("Arg[(0}] = {1}", x, args[x]);
            }
            Console.WriteLine("===================================================");
#endif
            string buffer;

            StreamReader myFile = File.OpenText(args[0]);

            while((buffer = myFile.ReadLine()) != null)
            {
#if BOOKCHECK
                if(buffer.Length > 72)
                {
                    Console.WriteLine("*** Following line too wide to present in book ***");
                }

                Console.Write("{0:D3}   - ", buffer.Length);
#endif
                Console.WriteLine(buffer);
            }

            myFile.Close();
        }
    }
}