using System;
using System.Collections.Generic;
using ImovelGo.Core.Domain;
using ImovelGo.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImovelGo.WebApi.UseCases.GetAllCities
{
    public sealed class Presenter
    {
        public IActionResult ViewModel { get; private set; }

        public void Populate(List<CityDTO> output)
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
