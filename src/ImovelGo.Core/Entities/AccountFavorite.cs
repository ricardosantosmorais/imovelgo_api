using System;
namespace ImovelGo.Core.Entities
{
    public class AccountFavorite
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int PropertyId { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
