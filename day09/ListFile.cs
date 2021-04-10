using System;
using System.IO;

class ListFile
{
    public static void Main(string[] args)
    {
        try
        {
            int ctr = 0;
            if(args.Length <= 0)
            {
                Console.WriteLine("Format: ListFile filename");
                return;
            }
            else
            {
                FileStream fstr = new FileStream(args[0], FileMode.Open);
                try
                {
                    StreamReader sReader = new StreamReader(fstr);
                    string line;
                    while((line = sReader.ReadLine()) != null)
                    {
                        ctr += 1;
                        Console.WriteLine("{0}:     {1}", ctr, line);
                    }
                }
                catch (System.Exception e)
                {
                    Console.WriteLine("Exception during read/write: {0}\n", e);
                }
                finally
                {
                    fstr.Close();
                }
            }
        }
        catch(System.IO.FileNotFoundException)
        {
            Console.WriteLine("ListFile could not find the file {0}", args[0]);
        }
        catch (System.Exception e)
        {
            Console.WriteLine("Exception: {0}\n\n", e);
        }
    }
}