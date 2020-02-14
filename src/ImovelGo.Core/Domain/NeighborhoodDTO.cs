using System;
namespace ImovelGo.Core.Domain
{
    public class NeighborhoodDTO
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public int? ZoneId { get; set; }
        public DateTime DateAdd { get; set; }
        public bool Enabled { get; set; }

        public ZoneDTO Zone { get; set; }
        public CityDTO City { get; set; }

        public NeighborhoodDTO()
        {
        }
    }
}
