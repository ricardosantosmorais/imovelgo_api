using System;
namespace ImovelGo.Core.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int AccountId { get; set; }
        public Guid PostId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Resume { get; set; }
        public string HtmlContent { get; set; }
        public string PhotoUrl { get; set; }
        public int PageViews { get; set; }
        public string Tags { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Enabled { get; set; }
        public bool Deleted { get; set; }
        public bool Published { get; set; }

        public Post()
        {
        }
    }
}
