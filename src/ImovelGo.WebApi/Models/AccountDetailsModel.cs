using System;
namespace ImovelGo.WebApi.Models
{
    public class AccountDetailsModel
    {
        public int Id { get; set; }
        public Guid AccountId { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Cpf { get; set; }
        public string DocumentNumber { get; set; }
        public int DDDCellPhone { get; set; }
        public int CellPhone { get; set; }

        public AccountDetailsModel(int id, Guid accountId)
        {
            Id = id;
            AccountId = accountId;
        }
    }
}
