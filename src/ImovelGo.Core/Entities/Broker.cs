using System;
namespace ImovelGo.Core.Entities
{
    public class Broker
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int CompanyId { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Enabled { get; set; }
        public bool Deleted { get; set; }
    }
}
