using System;
namespace ImovelGo.Core.Domain
{
    public class PostCommentDTO
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int AccountId { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Enabled { get; set; }

        public PostCommentDTO()
        {
        }
    }
}
