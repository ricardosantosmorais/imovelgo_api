using System;
using System.Collections.Generic;
using AutoMapper;
using ImovelGo.Core.Entities;

namespace ImovelGo.Core.Domain
{
    public class CompanyDTO
    {
        public int Id { get; set; }
        public int TemplateId { get; set; }
        public Guid CompanyId { get; set; }
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
        public string Domain { get; set; }
        public string GooglePlay { get; set; }
        public string AppStore { get; set; }

        public TemplateDTO Template { get; set; }
        public List<PageDTO> Pages { get; set; }
        public List<AddressDTO> Address { get; set; }
        public List<AccountDTO> Agents { get; set; }

        public CompanyDTO()
        {
        }
    }
}
