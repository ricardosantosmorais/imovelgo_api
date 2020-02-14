using System;
namespace ImovelGo.Application
{
    public class ApplicationException : System.Exception
    {
        internal ApplicationException(string businessMessage) : base(businessMessage) { }
    }
}
