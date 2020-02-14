using System;
namespace ImovelGo.Application
{
    public class Response<T>
    {
        public int Code { get; set; }
        public bool Success { get; set; }
        public T Data { get; set; }
    }
}
