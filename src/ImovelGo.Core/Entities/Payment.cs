using System;
namespace ImovelGo.Core.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public int CompanyId { get; set; }
        public decimal Value { get; set; }
        public decimal Price { get; set; }
        public DateTime Validity { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
