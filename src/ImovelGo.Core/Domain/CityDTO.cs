using System;
namespace ImovelGo.Core.Domain
{
    public class CityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public DateTime DateAdd { get; set; }
        public bool Enabled { get; set; }

        public StateDTO State { get; set; }

        public CityDTO()
        {
        }
    }
}
