using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class StudentMain
    {
        static void Main()
        {
            List<Student> studentList = new List<Student>();

            studentList.Add(new Student("Penko", "Penkov", 19, "378204", new List<double> { 2, 5, 3, 3 }, "0889776523", "penko_penkov@abv.bg", "Physics"));
            studentList.Add(new Student("Genko", "Genkov", 29, "341104", new List<double> { 2, 2 }, "0979786523", "g_genkov@gmail.com", "Mathematics"));
            studentList.Add(new Student("Stancho", "Prosenikov", 27, "298705", new List<double> { 5, 4, 5, 6 }, "0866776595", "stancho@abv.bg", "Informatics"));
            studentList.Add(new Student("Ferdi", "Mravkata", 22, "277206", new List<double> { 6, 5 }, "02887665", "maya_bee@yahoo.com", "Economics"));
            studentList.Add(new Student("Oli", "Frenov", 22, "2888506", new List<double> { 2, 2 }, "02887665", "oligofren@yahoo.com", "2"));



            Console.WriteLine("Problem 3. First before last");
            Console.WriteLine(string.Join(",\n", Student.FirsBeforLast(studentList)));
            Console.WriteLine();

            Console.WriteLine("Problem 4. Age range");
            Console.WriteLine(string.Join(",\n", Student.AgeBetween(studentList)));
            Console.WriteLine();

            Console.WriteLine("Problem 5. Order students");
            Console.WriteLine(string.Join(",\n", Student.OrderStudents(studentList)));
            Console.WriteLine();

            Console.WriteLine("Problem 9.Student groups");
            Console.WriteLine(string.Join(",\n", Student.GroupTwoStudent(studentList)));
            Console.WriteLine();

            Console.WriteLine("Problem 10. Student groups extensions");
            Console.WriteLine(string.Join(",\n", Student.GroupTwoStudentExt(studentList)));
            Console.WriteLine();

            Console.WriteLine("Problem 11. Extract students by email");
            Console.WriteLine(string.Join(",\n", Student.StudentEmail(studentList)));
            Console.WriteLine();

            Console.WriteLine("Problem 12. Extract students by phone");
            Console.WriteLine(string.Join(",\n", Student.StudentTelefonInSofiq(studentList)));
            Console.WriteLine();

            Console.WriteLine("Problem 13. Extract students by marks");
            Student.StudentWithSix(studentList);
            Console.WriteLine();

            Console.WriteLine("14. Extract students with two marks");
            Console.WriteLine(string.Join(",\n", Student.StudentWithMarkTwo(studentList)));
            Console.WriteLine();

            Console.WriteLine("Problem 15. Extract marks");
            Student.StudentTwoHundred(studentList);
            Console.WriteLine();

            Console.WriteLine("Problem 18. Grouped by GroupNumber");
            Console.WriteLine(string.Join(",\n", Student.StudentGroup(studentList)));
            Console.WriteLine();

            Console.WriteLine("Problem 19. Grouped by GroupName extensions");
            Student.StudentGroupExt(studentList);
            Console.WriteLine();

           

        }
    }
}
