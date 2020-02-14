using System;
namespace ImovelGo.Core.Entities
{
    public class PostCategory
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Enabled { get; set; }
        public bool Deleted { get; set; }

        public PostCategory()
        {
        }
    }
}
