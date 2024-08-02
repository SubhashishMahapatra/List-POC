using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeDetails.Model
{
    internal class College
    {
        public int CollegeId { get; set; }
        public string CollegeName { get; set; }

        public List<Student> students = new List<Student>();       //List Creation
        public List<Professor> professors = new List<Professor>();
        public List<Department> departments = new List<Department>();

        public College(int collegeId, string collegeName)
        {
            CollegeId = collegeId;
            CollegeName = collegeName;
        }
    }
}
