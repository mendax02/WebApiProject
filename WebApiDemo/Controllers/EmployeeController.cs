using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class EmployeeController : ApiController
    {
        public IHttpActionResult PostNewEmployee(EmployeeModel employee)
        {

            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            using (var ctx = new TrainingEntities())
            {
                ctx.Employees.Add(
                    new Employee {
                        EmployeeId = employee.EmployeeId,
                        EmployeeName= employee.EmployeeName,
                        EmployeeRole = employee.EmployeeRole,
                        DepartmentId = employee.DepartmentId });
                // employees.Add(employee);
                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}
