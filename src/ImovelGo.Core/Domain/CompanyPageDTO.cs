using System;
namespace ImovelGo.Core.Domain
{
    public class CompanyPageDTO
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int PageId { get; set; }
        public string Title { get; set; }
        public DateTime DateAdd { get; set; }
        public bool Enabled { get; set; }

        public CompanyPageDTO()
        {
        }
    }
}
