using System;
using System.Collections.Generic;

namespace ImovelGo.Core.Domain
{
    public class PagedResultsDTO<T>
    {
        public IEnumerable<T> Items { get; set; }
        public int TotalCount { get; set; }
    }
}
