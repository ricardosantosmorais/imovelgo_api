﻿using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using ImovelGo.Core;

namespace ImovelGo.WebApi.Filters
{
    public class DomainExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            DomainException domainException = context.Exception as DomainException;
            if (domainException != null)
            {
                string json = JsonConvert.SerializeObject(domainException.Message);

                context.Result = new BadRequestObjectResult(json);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
        }
    }
}
