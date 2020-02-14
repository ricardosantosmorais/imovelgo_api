using System;
namespace ImovelGo.Application.Exception
{
    internal sealed class AccountNotFoundException : ApplicationException
    {
        internal AccountNotFoundException(string message) : base(message) { }
    }
}
