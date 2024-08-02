using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeDetails.Model
{
    internal class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public Department(int departmentId, string departmentName)
        {
            DepartmentID = departmentId;
            DepartmentName = departmentName;
        }

      

    }
}
