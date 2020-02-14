using System;
using AutoMapper;
using ImovelGo.Core.Entities;

namespace ImovelGo.Core.Domain
{
    public class FilterDTO
    {
        public int CompanyId { get; set; }
        public int GoalId { get; set; } //Venda ou aluguel
        public string Keyword { get; set; }
        public int? MinValue { get; set; }
        public int? MaxValue { get; set; }
        public int? BathRoom { get; set; }
        public int? BedRoom { get; set; }
        public int? Type { get; set; }
        public int? Vacancy { get; set; }
        public int? NeightborhoodId { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public int? ZoneId { get; set; }
        public int? CountryId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public double? MinArea { get; set; }
        public double? MaxArea { get; set; }
        public bool? NearMetro { get; set; }
        public bool? NearBeach { get; set; }
        public bool? AirCondition { get; set; }
        public bool? Heating { get; set; }
        public bool? PetAccept { get; set; }
        public bool? Furnished { get; set; }

        public int OffSet { get; set; }
        public int PageSize { get; set; }
    }
}
