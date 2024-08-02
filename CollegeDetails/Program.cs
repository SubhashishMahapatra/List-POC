using System.Collections.Generic;
using CollegeDetails.Model;

class Program
{
    static void Main(string[] args)
    {

        Student student1 = new Student(2, "Subhashish");
        Student student2 = new Student(3, "Prasad");

        Professor professor1 = new Professor(1, "Rohit");
        Professor professor2 = new Professor(2, "Shantanu");

        Department department1 = new Department(01, "IT");
        Department department2 = new Department(02, "CS");

        College college = new College(4, "APSIT");
        college.students.Add(student1);              // Add Operations in List
        college.students.Add(student2);

        college.professors.Add(professor1);
        college.professors.Add(professor2);

        college.departments.Add(department1);
        college.departments.Add(department2);

        AllMenu.MainMenu(college, college.students, college.departments, college.professors);  //Remove Update Delete Operartion Performed in this menus

    }
}