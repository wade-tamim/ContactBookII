using System;
using System.Collections.Generic;
using ContactBookUmbracoAPI.API.Models;
using Umbraco.Core.Services;

namespace ContactBookUmbracoAPI.API.Controllers
{
    public class DepartmentsController : Umbraco.Web.WebApi.UmbracoApiController
    {
        // GET: Department
        public IEnumerable<DepartmentModel> GetAllDepartments()
        {
            //IContentTypeService contentTypeService = Services.ContentTypeService;

            IContentService contentService = Services.ContentService;

            var countriesIds = new Dictionary<int, string>();

            var CompanyHQChildren = contentService.GetChildren(1066);

            var departmentsList = new List<DepartmentModel>();

            foreach (var country in CompanyHQChildren)
            {
                countriesIds.Add(country.Id, country.Name);
            }

            foreach (var country in countriesIds)
            {
                var departments = contentService.GetChildren(country.Key);
                foreach (var dep in departments)
                {
                    departmentsList.Add(new DepartmentModel()
                    {
                        Id = dep.Id,
                        Address = dep.Properties[0].Value.ToString(),
                        LandName = country.Value,
                        Name = dep.Properties[3].Value.ToString(),
                        PhoneNumber = Int64.Parse(dep.Properties[2].Value.ToString()),
                    });
                }
            }
            return departmentsList;
        }

    }

}