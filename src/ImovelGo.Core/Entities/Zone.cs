using System;
namespace ImovelGo.Core.Entities
{
    public class Zone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public DateTime DateAdd { get; set; }
        public bool Enabled { get; set; }
    }
}
