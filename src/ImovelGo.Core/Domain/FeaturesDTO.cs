using System;
namespace ImovelGo.Core.Domain
{
    public class FeaturesDTO
    {
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Enabled { get; set; }

        public FeaturesDTO()
        {
        }
    }
}
