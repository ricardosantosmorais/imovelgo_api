using System;
using System.Collections.Generic;
using ImovelGo.Core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ImovelGo.WebApi.UseCases.SeachPropertiesByCompany
{
    public sealed class Presenter
    {
        public IActionResult ViewModel { get; private set; }

        public void Populate(PagedResultsDTO<PropertyDTO> output)
        {
            if (output == null)
            {
                ViewModel = new NoContentResult();
                return;
            }

            ViewModel = new ObjectResult(output);
        }
    }
}
