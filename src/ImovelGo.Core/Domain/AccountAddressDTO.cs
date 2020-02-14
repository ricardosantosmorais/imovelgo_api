using System;
namespace ImovelGo.Core.Domain
{
    public class AccountAddressDTO
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int AddressId { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
