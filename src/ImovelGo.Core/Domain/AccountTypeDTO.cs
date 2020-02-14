using System;
namespace ImovelGo.Core.Domain
{
    public class AccountTypeDTO
    {
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Enabled { get; set; }
        public bool Deleted { get; set; }

        public AccountTypeDTO()
        {
        }
    }
}
