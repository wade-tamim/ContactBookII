using System;
using System.Collections;
using System.Collections.Generic;
using ContactBookUmbracoAPI.API.Models;
using Umbraco.Core.Services;
using Umbraco.Core.Models;

namespace ContactBookUmbracoAPI.API.Controllers
{
    public class EmployeesController : Umbraco.Web.WebApi.UmbracoApiController
    {
        // GET: Employees
        public IEnumerable<EmployeeModel> GetAllEmployees()
        {

            IContentService contentService = Services.ContentService;

            var countriesIds = new Dictionary<int, string>();

            var departmentsIds = new Dictionary<int, string>();

            var companyHqChildren = contentService.GetChildren(1066);

            IEnumerable<IContent> departments = new List<IContent>();

            var employeesList = new List<EmployeeModel>();

            foreach (var country in companyHqChildren)
            {
                countriesIds.Add(country.Id, country.Name);
            }

            foreach (var id in countriesIds)
            {
                departments = contentService.GetChildren(id.Key);

                foreach (var department in departments)
                {

                    var employees = contentService.GetChildren(department.Id);

                    foreach (var emp in employees)
                    {
                        employeesList.Add(new EmployeeModel()
                        {
                            Id = emp.Id,
                            FirstName = emp.Properties[1].Value.ToString(),
                            LastName = emp.Properties[6].Value.ToString(),
                            Department = department.Properties[3].Value.ToString(),
                            Email = emp.Properties[5].Value.ToString(),
                            Phone = emp.Properties[4].Value.ToString(),
                            Address = emp.Properties[2].Value.ToString(),
                            Country = id.Value,
                        });
                    }
                }
            }

            return employeesList;
        }
    }
}