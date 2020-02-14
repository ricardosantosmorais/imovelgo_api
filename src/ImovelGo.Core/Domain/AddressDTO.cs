using System;
using AutoMapper;
using ImovelGo.Core.Entities;

namespace ImovelGo.Core.Domain
{
    public class AddressDTO
    {
        public int Id { get; set; }
        public Guid AddressId { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public int NeighborhoodId { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public int PostalCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool Main { get; set; }

        public NeighborhoodDTO Neighborhood { get; set; }
        public CityDTO City { get; set; }
        public StateDTO State { get; set; }
        public CountryDTO Country { get; set; }

        public AddressDTO() { }
    }
}
