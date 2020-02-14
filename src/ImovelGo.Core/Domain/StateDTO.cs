using System;
namespace ImovelGo.Core.Domain
{
    public class StateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public string Abbreviation { get; set; }
        public DateTime DateAdd { get; set; }
        public bool Enabled { get; set; }

        public CountryDTO Country { get; set; }

        public StateDTO()
        {
        }
    }
}
