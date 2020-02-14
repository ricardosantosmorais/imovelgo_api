using System;
namespace ImovelGo.Core.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public Guid AccountId { get; set; }
        public int AccountTypeId { get; set; }
        public string Avatar { get; set; }
        public string FistName { get; set; }
        public string Position { get; set; }
        public string LastName { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Cpf { get; set; }
        public string DocumentNumber { get; set; }
        public int DDDCellPhone { get; set; }
        public string CellPhone { get; set; }
        public bool Terms { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Enabled { get; set; }
        public bool Deleted { get; set; }
    }
}
