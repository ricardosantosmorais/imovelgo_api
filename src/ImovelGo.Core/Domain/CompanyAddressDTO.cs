using System;
namespace ImovelGo.Core.Domain
{
    public class CompanyAddressDTO
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int AddressId { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
