using System;
namespace ImovelGo.Core.Domain
{
    public class PropertyTypeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Enabled { get; set; }
        public bool Deleted { get; set; }

        public PropertyTypeDTO()
        {
        }
    }
}
