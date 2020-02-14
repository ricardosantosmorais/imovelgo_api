using System;
namespace ImovelGo.Core.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public Guid AddressId { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public int NeighborhoodId { get; set; }
        public int? ZoneId { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public int PostalCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Enabled { get; set; }
        public bool Deleted { get; set; }
        public bool Main { get; set; }
    }
}
