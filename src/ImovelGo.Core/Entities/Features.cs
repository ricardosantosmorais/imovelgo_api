using System;
namespace ImovelGo.Core.Entities
{
    public class Features
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Enabled { get; set; }
    }
}
