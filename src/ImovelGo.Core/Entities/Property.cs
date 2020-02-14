using System;
using System.Collections.Generic;

namespace ImovelGo.Core.Entities
{
    public class Property
    {
        public int Id { get; set; }
        public int PropertyTypeId { get; set; }
        public int GoalId { get; set; } //Vender ou alugar (1 - vender, 2 - alugar)
        public int? BrokerId { get; set; }
        public int CompanyId { get; set; }
        public int StatusId { get; set; }
        public int AddressId { get; set; }
        public int Bedroom { get; set; }
        public int? SalePrice { get; set; } //Preço da venda
        public int? RentPrice { get; set; } //Preço do aluguel
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
        public bool Enabled { get; set; }
        public bool Deleted { get; set; }
        public bool Published { get; set; }
        public int? Floor { get; set; }
        public bool PetAccept { get; set; }
        public bool Furnished { get; set; }
        public bool NearMetro { get; set; }
        public bool NearBeach { get; set; }
        public bool AirCondition { get; set; }
        public bool Heating { get; set; }

        public virtual Address Address { get; set; }
        public virtual PropertyType PropertyType { get; set; }
        public virtual List<PropertyPhoto> Photos { get; set; }
    }
}
