using System;
using ImovelGo.Core.Domain;
using ImovelGo.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImovelGo.WebApi.UseCases.GetAccountDetails
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

            ViewModel = new ObjectResult(new AccountDetailsModel(output.id, output.AccountId));
        }
    }
}
