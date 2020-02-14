using System;
namespace ImovelGo.Core.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public int? AccountId { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Enabled { get; set; }
        public bool Deleted { get; set; }

        public Review()
        {
        }
    }
}
