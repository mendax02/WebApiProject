using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class EmployeeModel
    {
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeRole { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        //public ICollection<EmployeeModel> Employees { get; set; }
    }
}