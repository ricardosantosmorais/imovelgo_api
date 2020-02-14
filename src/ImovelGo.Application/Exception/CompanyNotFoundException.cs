using System;
namespace ImovelGo.Application.Exception
{
    internal sealed class CompanyNotFoundException : ApplicationException
    {
        internal CompanyNotFoundException(string message) : base(message) { }
    }
}
