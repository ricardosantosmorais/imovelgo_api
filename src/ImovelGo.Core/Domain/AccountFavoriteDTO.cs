using System;
namespace ImovelGo.Core.Domain
{
    public class AccountFavoriteDTO
    {
        public int id { get; set; }
        public int AccountId { get; set; }
        public int PropertyId { get; set; }
        public DateTime DateAdd { get; set; }

        public AccountFavoriteDTO()
        {
        }
    }
}
