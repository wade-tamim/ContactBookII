using System;
using System.Collections.Generic;
using ContactBookUmbracoAPI.API.Models;
using Umbraco.Core.Services;

namespace ContactBookUmbracoAPI.API.Controllers
{
    public class CountriesController : Umbraco.Web.WebApi.UmbracoApiController
    {
        // GET: Department
        public IEnumerable<CountryModel> GetAllCountries()
        {
            IContentService contentService = Services.ContentService;

            var CompanyHQChildren = contentService.GetChildren(1066);

            var countriesList = new List<CountryModel>();

            foreach (var country in CompanyHQChildren)
            {
                countriesList.Add(new CountryModel()
                {
                    Id = country.Id,
                    Name = country.Name,
                });
            }

            return countriesList;
        }

    }

}