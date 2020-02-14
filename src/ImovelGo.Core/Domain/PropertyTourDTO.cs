using System;
namespace ImovelGo.Core.Domain
{
    public class PropertyTourDTO
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int AccountId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Confirmed { get; set; }
        public bool Enabled { get; set; }
        public bool Deleted { get; set; }

        public PropertyTourDTO()
        {
        }
    }
}
