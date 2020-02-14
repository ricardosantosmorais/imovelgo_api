using System;
namespace ImovelGo.Core.Entities
{
    public class PropertyMessage
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int? AccountId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
