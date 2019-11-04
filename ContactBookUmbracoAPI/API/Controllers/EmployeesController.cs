using System.Collections.Generic;
using System.Linq;
using ContactBookUmbracoAPI.API.Models;
using Umbraco.Core.Services;
using Umbraco.Core.Models;
using System.Web.Mvc;
using Umbraco.RestApi.Routing;

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
                            FullName = emp.Properties[1].Value.ToString() +" "+emp.Properties[6].Value.ToString(),
                            Department = department.Properties[3].Value.ToString(),
                            Country = id.Value,
                        });
                    }
                }
            }

            return employeesList;
        }

        // GET: Employee by id 
        [Route("{ids:int}")]
        [System.Web.Http.HttpGet]
        public EmployeeModel GetEmployeeById(int ids)
        {
            IContentService contentService = Services.ContentService;
            
            var employee = contentService.GetById(ids);
            var empModel = new EmployeeModel()
            {
                Id = employee.Id,
                FirstName = GetValue(employee.Properties[1].Value),
                LastName = GetValue(employee.Properties[6].Value),
                Address = GetValue(employee.Properties[2].Value),
                Phone = GetValue(employee.Properties[4].Value),
                Email = GetValue(employee.Properties[5].Value),
                Department = GetValue(employee.Properties[3].Value),
                CompanyNumber = GetValue(employee.Properties[0].Value)
            };
            return empModel;
        }

        public string GetValue(object value)
        {
            return value == null ? "" : value.ToString();
        }
    }
}

//https://localhost:44328/umbraco/api/employees/Getemployeebyid?ids=1088