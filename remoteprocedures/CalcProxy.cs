// csc /t:library CalcProxy.cs

using System.Diagnostics;
using System.Xml.Serialization;
using System;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Web.Services;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="CalcSoap", Namespace="http://tempuri.org/")]
public class Calc : System.Web.Services.Protocols.SoapHttpClientProtocol
{
    public Calc()
    {
        this.Url = "http://localhost/WebCalc.asmx";
    }

    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Add", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal,ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public int Add(int x, int y)
    {
        object[] results = this.Invoke("Add", new object[] {x,y});
        return ((int) (results[0]));
    }

    public System.IAsyncResult BeginAdd(int x, int y, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("Add", new object[] {x,y}, callback, asyncState);
    }

    public int EndAdd(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((int)(results[0]));
    }

    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Subtract", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal,ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public int Subtract(int x, int y)
    {
        object[] results = this.Invoke("Subtract", new object[] {x, y});
        return ((int) (results[0]));
    }

    public System.IAsyncResult BeginSubtract(int x, int y, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("Subtract", new object[] {x,y}, callback, asyncState);
    }

    public int EndSubtract(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((int) (results[0]));
    }
}