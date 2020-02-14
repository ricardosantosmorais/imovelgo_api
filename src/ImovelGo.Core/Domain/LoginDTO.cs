using System;
namespace ImovelGo.Core.Domain
{
    public class LoginDTO
    {
        public int id { get; set; }
        public int AccountId { get; set; }
        public DateTime DateAdded { get; set; }
        public string Ip { get; set; }

        public LoginDTO()
        {
        }
    }
}
