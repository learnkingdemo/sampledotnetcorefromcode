using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sampledotnetcore.Models;

namespace sampledotnetcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        static List<EmployeeClass> employees = new List<EmployeeClass>()
        {
            new EmployeeClass{empID = "7",empName = "Muthu",empEmailID = "muthu@nokia.com",jobTitle = "Tech lead"},
            new EmployeeClass{empID = "8",empName = "samy",empEmailID = "samy@nokia.com",jobTitle = "lead"},
            new EmployeeClass{empID = "9",empName = "divya",empEmailID = "divya@nokia.com",jobTitle = "manager"}

        };

        [HttpGet]
        public IEnumerable<EmployeeClass> GetEmployeesList()
        {
            return employees;
        }

        [HttpPost]
        public void PostEmployeesList([FromBody]EmployeeClass objEmbloyee)
        {
            employees.Add(objEmbloyee);
        }

        [HttpPut("{empid}")]
        public void PutEmployeesList1(int empid, [FromBody] EmployeeClass objEmbloyee)
        {
            employees[empid] = objEmbloyee;
        }

        [HttpDelete("{empid}")]
        public void DeleteEmployeesList1(int empid)
        {
            employees.RemoveAt(empid);
        }
    }
}
