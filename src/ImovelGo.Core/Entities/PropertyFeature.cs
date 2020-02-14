using System;
namespace ImovelGo.Core.Entities
{
    public class PropertyFeature
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int FeatureId { get; set; }
        public DateTime DateAdd { get; set; }
        public bool Enabled { get; set; }
    }
}
