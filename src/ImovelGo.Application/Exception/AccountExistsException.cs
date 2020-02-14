using System;
namespace ImovelGo.Application.Exception
{
    public class AccountExistsException : ApplicationException
    {
        public AccountExistsException(string message) : base(message) { }
    }
}
