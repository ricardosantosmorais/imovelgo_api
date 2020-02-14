using System;
using System.Collections.Generic;

namespace ImovelGo.Core.Domain
{
    public class PropertyDTO
    {
        public int Id { get; set; }
        public int PropertyTypeId { get; set; }
        public int GoalId { get; set; }
        public int? BrokerId { get; set; }
        public int CompanyId { get; set; }
        public int StatusId { get; set; }
        public int AddressId { get; set; }
        public int Bedroom { get; set; }
        public int? SalePrice { get; set; }
        public int? RentPrice { get; set; }
        public int? Discount { get; set; }
        public int? TaxPrice { get; set; }
        public int? CondominiumPrice { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int? Suite { get; set; }
        public int? BathRoom { get; set; }
        public int? Vacancies { get; set; }
        public string VideoUrl { get; set; }
        public double? UsefulAreaWidth { get; set; }
        public double? UsefulAreaDepth { get; set; }
        public double? TotalAreaWidth { get; set; }
        public double? TotalAreaDepth { get; set; }
        public double? PrivateAreaWidth { get; set; }
        public double? PrivateAreaDepth { get; set; }
        public bool IsNew { get; set; }
        public bool Featured { get; set; }
        public int PageViews { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Published { get; set; }
        public bool Enabled { get; set; }
        public bool Deleted { get; set; }
        public int? Floor { get; set; }
        public bool PetAccept { get; set; }
        public bool Furnished { get; set; }
        public bool NearMetro { get; set; }

        public PropertyTypeDTO PropertyType { get; set; }
        public AddressDTO Address { get; set; }
        public BrokerDTO Broker { get; set; }
        public List<PropertyPhotoDTO> Photos { get; set; }

        public PropertyDTO()
        {
        }
    }
}
