using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeDetails.Model
{
    internal class AllMenu
    {
        public static void MainMenu(College college, List<Student> students, List<Department> departments, List<Professor> professors)
        {
            bool programRunning = true;

            while (programRunning)
            {
                Console.WriteLine("Choose the option: 1. Update the List  2. Delete the list  3. Print List 4. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        UpdateListMenu(college, students, departments, professors);
                        break;
                    case 2:
                        DeleteListMenu(college, students, departments, professors);
                        break;
                    case 3:
                        PrintDetails(college, students, departments, professors);
                        break;
                    case 4:
                        programRunning = false;
                        break;
                }

            }
        }


        public static void DeleteListMenu(College college, List<Student> students, List<Department> departments, List<Professor> professors)
        {
            bool programRunning = true;

            while (programRunning)
            {
                Console.WriteLine("Choose the option to Delete your list: 1. Student  2. Professor  3. Department 4. PrintDetails 5.Go to previous Menu");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        StudentRemoveList(students);
                        break;
                    case 2:
                        ProfessorRemoveList(professors);
                        break;
                    case 3:
                        DepartmentRemoveList(departments);
                        break;
                    case 4:
                        PrintDetails(college, college.students, college.departments, college.professors);
                        break;
                    case 5:
                        programRunning = false;
                        break;

                }
            }
        }

        public static void UpdateListMenu(College college, List<Student> students, List<Department> departments, List<Professor> professors)
        {

            bool programRunning = true;

            while (programRunning)
            {
                Console.WriteLine("Choose the option to upadte your list: 1. Student  2. Professor  3. Department 4. PrintDetails 5.Go to previous Menu");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        StudentUpdateList(students);
                        break;
                    case 2:
                        ProfessorUpdateList(professors);
                        break;
                    case 3:
                        DepartmentUpdateList(departments);
                        break;
                    case 4:
                        PrintDetails(college, college.students, college.departments, college.professors);
                        break;
                    case 5:
                        programRunning = false;
                        break;

                }
            }

        }

        public static void StudentRemoveList(List<Student> students)
        {
            Console.WriteLine("Enter the Student Id to delete it's data: ");
            int id = int.Parse(Console.ReadLine());
            foreach (Student student in students)
            {
                if (student.StudentId == id)
                {

                    students.Remove(student);
                    Console.WriteLine($"Student {student.StudentName} Removed Successfully");
                    break;
                }

            }

        }

        public static void ProfessorRemoveList(List<Professor> professors)
        {
            Console.WriteLine("Enter the Professor Id to delete it's data: ");
            int id = int.Parse(Console.ReadLine());
            foreach (Professor professor in professors)
            {
                if (professor.ProfessorId == id)
                {

                    professors.Remove(professor);
                    Console.WriteLine($"Student {professor.ProfessorName} Removed Successfully");
                    break;
                }

            }
        }

        public static void DepartmentRemoveList(List<Department> departments)
        {
            Console.WriteLine("Enter the Department Id to delete it's data: ");
            int id = int.Parse(Console.ReadLine());
            foreach (Department department in departments)
            {
                if (department.DepartmentID == id)
                {

                    departments.Remove(department);
                    Console.WriteLine($"Student {department.DepartmentName} Removed Successfully");
                    break;
                }

            }
        }

        public static void StudentUpdateList(List<Student> students)
        {
            Console.WriteLine("Enter the Student Id to edit: ");
            int id = int.Parse(Console.ReadLine());

            foreach (Student student in students)
            {
                if (student.StudentId == id)
                {
                    Console.WriteLine($"Welcome {student.StudentName}");
                    Console.WriteLine("Enter your Updated Name: ");
                    string name = Console.ReadLine();
                    student.StudentName = name;
                    Console.WriteLine("Name has been updated successfully!");
                }

            }
        }

        public static void ProfessorUpdateList(List<Professor> professors)
        {
            Console.WriteLine("Enter the Professor Id to edit: ");
            int id = int.Parse(Console.ReadLine());

            foreach (Professor professor in professors)
            {
                if (professor.ProfessorId == id)
                {
                    Console.WriteLine($"Welcome {professor.ProfessorName}");
                    Console.WriteLine("Enter your Updated Name: ");
                    string name = Console.ReadLine();
                    professor.ProfessorName = name;
                    Console.WriteLine("Name has been updated successfully!");
                }

            }
        }

        public static void DepartmentUpdateList(List<Department> departments)
        {
            Console.WriteLine("Enter the Departmennt Id to edit: ");
            int id = int.Parse(Console.ReadLine());

            foreach (Department department in departments)
            {
                if (department.DepartmentID == id)
                {
                    Console.WriteLine($"Welcome, your department is {department.DepartmentName}");
                    Console.WriteLine("Enter your Updated Name: ");
                    string name = Console.ReadLine();
                    department.DepartmentName = name;
                    Console.WriteLine("Name has been updated successfully!");
                }

            }
        }



        public static void PrintDetails(College college, List<Student> students, List<Department> departments, List<Professor> professors)
        {
            Console.WriteLine("College Details are: ");
            Console.WriteLine();

            Console.WriteLine("College Id: " + college.CollegeId);
            Console.WriteLine("College Name: " + college.CollegeName);
            Console.WriteLine();




            Console.WriteLine("Department Details are: ");
            Console.WriteLine();

            foreach (Department department in departments)
            {
                Console.WriteLine("Department Id: " + department.DepartmentID);
                Console.WriteLine("Department Name: " + department.DepartmentName);
                Console.WriteLine();
            }


            Console.WriteLine("Professor Details are: ");
            Console.WriteLine();
            foreach (Professor professor in professors)
            {
                Console.WriteLine("Professor Id is: " + professor.ProfessorId);
                Console.WriteLine("Professor Name is: " + professor.ProfessorName);
                Console.WriteLine();
            }

            Console.WriteLine("Student Details are: ");
            Console.WriteLine();

            foreach (Student student in students)
            {
                Console.WriteLine("Student Id: " + student.StudentId);
                Console.WriteLine("Student Name: " + student.StudentName);
                Console.WriteLine();
            }




        }
    }
}
