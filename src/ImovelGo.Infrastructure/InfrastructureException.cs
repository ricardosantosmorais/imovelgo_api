using System;
namespace ImovelGo.Infrastructure
{
    public class InfrastructureException : Exception
    {
        internal InfrastructureException(string businessMessage) : base(businessMessage) { }
    }
}
