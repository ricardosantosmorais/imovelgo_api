using System;

namespace ImovelGo.Core.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public int TemplateId { get; set; }
        public Guid CompanyId { get; set; }
        public int PlanId { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Telephone { get; set; }
        public string MinDescription { get; set; }
        public string About { get; set; }
        public string ImageAbout { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Skype { get; set; }
        public string GooglePlay { get; set; }
        public string AppStore { get; set; }
        public string Domain { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Enabled { get; set; }
        public bool Deleted { get; set; }
    }
}
