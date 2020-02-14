using System;
namespace ImovelGo.Core.Entities
{
    public class CompanyAddress
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int AddressId { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
