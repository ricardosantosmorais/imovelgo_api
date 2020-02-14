using System;
namespace ImovelGo.Core.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public DateTime DateAdd { get; set; }
        public bool Enabled { get; set; }
    }
}
