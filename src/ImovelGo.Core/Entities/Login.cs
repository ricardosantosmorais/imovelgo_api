using System;
namespace ImovelGo.Core.Entities
{
    public class Login
    {
        public int id { get; set; }
        public int AccountId { get; set; }
        public string Token { get; set; }
        public DateTime DateAdded { get; set; }
        public string Ip { get; set; }
        public bool Enabled { get; set; }
    }
}
