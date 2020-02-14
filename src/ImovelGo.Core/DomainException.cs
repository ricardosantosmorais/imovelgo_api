using System;
namespace ImovelGo.Core
{
    public class DomainException : Exception
    {
        internal DomainException(string businessMessage) : base(businessMessage) { }
    }
}
