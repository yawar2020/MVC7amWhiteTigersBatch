using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApp.Models
{
    public class EmployeeModel
    {
        public int Empid { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
    }

    public class DepartmentModel
    {
        public int Deptid { get; set; }
        public string DeptName { get; set; }
    }
    public class EmpDept
    {
        public List<EmployeeModel> emp {get;set;}
        public List<DepartmentModel> dept {get;set;}
    }
}