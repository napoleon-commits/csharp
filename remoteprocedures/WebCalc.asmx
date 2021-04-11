<%@WebService Language="C#" Class="Calc"%>

using System;
using System.Web.Services;

public class Calc : WebService
{
    [WebMethod]
    public int Add(int x, int y)
    {
        return x + y;
    }

    [WebMethod]
    public int Subtract(int x, int y)
    {
        return x - y;
    }
}