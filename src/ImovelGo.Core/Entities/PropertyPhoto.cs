﻿using System;
namespace ImovelGo.Core.Entities
{
    public class PropertyPhoto
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Enabled { get; set; }
    }
}
