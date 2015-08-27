using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private byte age = default(int);
        private string fn = string.Empty;
        private string tel = string.Empty;
        private string email = string.Empty;
        private List<double> marks = new List<double>();
        private string groupNumber = string.Empty;
        

        public Student(string firstName, string lastName, byte age, string fn, List<double> marks, string tel, string email, string group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Fn = fn;
            this.marks = new List<double>(marks);
            this.Tel = tel;
            this.Email = email;
            this.GroupData = group;
        }

        public static string[] mails = {
                                        "@mail.bg",
                                        "@abv.bg",
                                        "@gmail.com"
                                   };

        //Problem 3. First before last

        //Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
        //Use LINQ query operators.
        public static List<Student> FirsBeforLast(List<Student> studentsArray)
        {
            var queryNameResults = from student in studentsArray
                                   where student.FirstName.CompareTo(student.LastName) < 0
                                   select student;
            return queryNameResults.ToList();
        }


        //Problem 4. Age range

        //Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
        public static List<string> AgeBetween(List<Student> studentsArray)
        {
            var queryNameResults = from student in studentsArray
                                   where student.Age > 18 && student.Age < 24
                                   select student.FirstName + " " + student.LastName;
           return queryNameResults.ToList();
        }

        //Problem 5. Order students

        //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
        //Rewrite the same with LINQ.
        public static List<Student> OrderStudents(List<Student> studentsArray)
        {
            
            var orderResult = studentsArray.OrderByDescending(fname => fname.FirstName)
                                           .ThenByDescending(lname => lname.LastName)
                                           .ToArray();
            return orderResult.ToList();
        }

        //Problem 9. Student groups

        //Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
        //Create a List<Student> with sample students. Select only the students that are from group number 2.
        //Use LINQ query. Order the students by FirstName.

        public static List<Student> GroupTwoStudent(List<Student> studentsArray)
        {

            var sampleStudents = from student in studentsArray
                                 where student.groupNumber == "2"
                                 orderby student.FirstName
                                 select student;
           return sampleStudents.ToList();
            
        }
        //Problem 10. Student groups extensions

        //Implement the previous using the same query expressed with extension methods.

        public static List<Student> GroupTwoStudentExt(List<Student> studentsArray)
        {

            var sampleWithExtensions = studentsArray.Where(x => x.groupNumber == "2").OrderBy(x => x.FirstName).ToList();
                              
            return sampleWithExtensions.ToList();

        }

        //Problem 11. Extract students by email

        //Extract all students that have email in abv.bg.
        //Use string methods and LINQ.

        public static List<Student> StudentEmail(List<Student> studentsArray)
        {

            var studentWithAbv = from student in studentsArray
                                 where student.Email.Substring(student.Email.IndexOf("@"), student.Email.Length - student.Email.IndexOf("@")) == mails[1]
                                 select student;

            return studentWithAbv.ToList();

        }

        //Problem 12. Extract students by phone

        //Extract all students with phones in Sofia.
        //Use LINQ.
        public static List<Student> StudentTelefonInSofiq(List<Student> studentsArray)
        {

            var studentWithPhoneInSofia = from student in studentsArray
                                          where student.Tel.Substring(0, 2) == "02"
                                          select student;

            return studentWithPhoneInSofia.ToList();

        }

        //Problem 13. Extract students by marks

        //Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
        //Use LINQ.

        public static void StudentWithSix(List<Student> studentsArray)
        {

            var annonymousStudents = from student in studentsArray
                                     where student.Marks.Contains(6)
                                     select new
                                     {
                                         FullName = string.Format("{0} {1}", student.FirstName, student.LastName),
                                         Marks = student.Marks,

                                     };

            foreach (var item in annonymousStudents)
            {
                Console.WriteLine("{0} - Marks:{1}", item.FullName, string.Join(", ", item.Marks));
            }

        }

        //Problem 14. Extract students with two marks

        //Write down a similar program that extracts the students with exactly two marks "2".
        //Use extension methods.

        public static List<Student> StudentWithMarkTwo(List<Student> studentsArray)
        {

            var StudentsWithTwo = studentsArray.Where(s => s.Marks.Count(m => m == (byte)2) == 2);

            return StudentsWithTwo.ToList();

        }
        //Problem 15. Extract marks

        //Extract all Marks of the students that enrolled in 2006.
        //(The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
        public static void StudentTwoHundred(List<Student> studentsArray)
        {

            var MarkFromTwoHundredSix = from student in studentsArray
                           where student.Fn.Substring(student.Fn.Length - 2) == "06"
                           select student.Marks;

            foreach (var item in MarkFromTwoHundredSix)
        {
            Console.Write("{0}, ", string.Join(", ", item));
        }

        }

        //Problem 18. Grouped by GroupNumber

        //Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
        //Use LINQ.

        public static List<Student> StudentGroup(List<Student> studentsArray)
        {

            var groupedStudents = from student in studentsArray
                                  group student by student.groupNumber into grouped
                                  from gr in grouped
                                  select gr;

            return groupedStudents.ToList();

        }

        //Problem 19. Grouped by GroupName extensions

        //Rewrite the previous using extension methods.

        public static void StudentGroupExt(List<Student> studentsArray)
        {

            var groupedStudentsExtensions = studentsArray.GroupBy(s => s.groupNumber);

            foreach (var group in groupedStudentsExtensions)
            {
                foreach (var student in group)
                {
                    Console.WriteLine(student);
                }
            }

        }


        
        public override string ToString()
        {
            return string.Format("Name: {0} {1}, Age: {2},Gr: {5}, Fn: {3}, Marks: {4}", firstName, lastName, age, fn, string.Join(", ", marks), GroupData);
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public byte Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Enter corect value!");
                }
                this.age = value;
            }
        }

        public string Fn
        {
            get { return this.fn; }
            set { this.fn = value; }
        }

        public List<double> Marks
        {
            get { return new List<double>(this.marks); }
        }

        public string Tel
        {
            get { return this.tel; }
            set { this.tel = value; }
        }

        public string Email
        {
            get { return this.email; }
            set 
            {
                if (!Regex.IsMatch(value, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                {
                    throw new ArgumentException();
                }
                this.email = value;
            }
        }

        public string GroupData
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }

        
    }
}
