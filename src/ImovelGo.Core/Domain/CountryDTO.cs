using System;
namespace ImovelGo.Core.Domain
{
    public class CountryDTO
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public DateTime DateAdd { get; set; }
        public bool Enabled { get; set; }

        public CountryDTO()
        {
        }
    }
}
