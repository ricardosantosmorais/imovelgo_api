using System;
using System.Collections.Generic;
using AutoMapper;
using ImovelGo.Core.Entities;

namespace ImovelGo.Core.Domain
{
    public class PageDTO
    {
        public int Id { get; set; }
        public string Html { get; set; }
        public string File { get; set; }
        public string Router { get; set; }
        public string FullPath { get; set; }
        public string Title { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Enabled { get; set; }
        public bool HeaderMenu { get; set; }
        public TemplateDTO Template { get; set; }
        public List<AreaDTO> Areas { get; set; }

        public PageDTO()
        {
        }
    }
}
