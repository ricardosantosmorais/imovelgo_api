using System;
namespace ImovelGo.Core.Domain
{
    public class ZoneDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public DateTime DateAdd { get; set; }
        public bool Enabled { get; set; }

        public CityDTO City { get; set; }

        public ZoneDTO()
        {
        }
    }
}
