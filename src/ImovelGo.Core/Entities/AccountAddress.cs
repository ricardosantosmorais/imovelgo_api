using System;
namespace ImovelGo.Core.Entities
{
    public class AccountAddress
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int AddressId { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
