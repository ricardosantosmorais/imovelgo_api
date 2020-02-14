using System;
using System.Collections.Generic;
using ImovelGo.Core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ImovelGo.WebApi.UseCases.RegisterAccount
{
    public sealed class Presenter
    {
        public IActionResult ViewModel { get; private set; }

        public void Populate(AccountDTO output)
        {
            if (output == null)
            {
                ViewModel = new NoContentResult();
                return;
            }

            output.Password = String.Empty;
            ViewModel = new ObjectResult(output);
        }
    }
}
