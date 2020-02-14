using System;
namespace ImovelGo.Core.Entities
{
    public class CompanyArea
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int AreaId { get; set; }
        public string Html { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Enabled { get; set; }

        public CompanyArea()
        {
        }
    }
}
