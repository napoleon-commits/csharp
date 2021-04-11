// csc /r:CalcProxy.dll WebClient.cs

using System;

public class WebClient
{
    public static void Main()
    {
        Calc cSrv = new Calc();

        Console.WriteLine("cSrv.Add(33,11); = {0}", cSrv.Add(33,11));
        Console.WriteLine("cSrv.Subtract(33,11); = {0}", cSrv.Subtract(33,11));
    }
}