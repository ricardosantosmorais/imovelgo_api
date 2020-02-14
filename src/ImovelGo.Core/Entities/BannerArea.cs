using System;
namespace ImovelGo.Core.Entities
{
    public class BannerArea
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int BannerId { get; set; }
        public int AreaId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpdated { get; set; }

        public BannerArea()
        {
        }
    }
}
