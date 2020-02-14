using System;
namespace ImovelGo.Core.Entities
{
    public class Page
    {
        public int Id { get; set; }
        public string Html { get; set; }
        public string File { get; set; }
        public string Router { get; set; }
        public string Title { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Enabled { get; set; }
        public bool HeaderMenu { get; set; }
    }
}
