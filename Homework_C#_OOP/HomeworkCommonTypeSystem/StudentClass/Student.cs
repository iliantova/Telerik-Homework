using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass 
{
    public enum Specialty { InformationSystems, SoftwareEngineering, Informatics, Mathematics };
    public enum University { Teleric, SofiaUniversity, TehnicalUniversity };
    public enum Faculty { Mathematics, Informatics, Education };



    public class Student : ICloneable
    {
        private string firstName = string.Empty;
        private string middleName = string.Empty;
        private string lastName = string.Empty;
        private int ssn = default(int);
        private string address = string.Empty;
        private string mobilePhone = string.Empty;
        private string email = string.Empty;
        private string course = string.Empty;

        public Specialty SpecialtyStudent { get; set; }
        public University UniversityStudent { get; set; }
        public Faculty FacultyStudent { get; set; }

        public Student() { }
        public Student(string firstName, string lastName, int ssn, Specialty SpecialtyStudent, University UniversityStudent, Faculty FacultyStudent,
            string course = null, string addres = null, string mobilePhone = null,
            string email = null, string middleName = null)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = addres;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;

            this.SpecialtyStudent = SpecialtyStudent;
            this.UniversityStudent = UniversityStudent;
            this.FacultyStudent = FacultyStudent;
        }
        #region Properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }

                this.lastName = value;
            }
        }

        public int SSN
        {
            get
            {
                return this.ssn;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("SSN must be positive number!");
                }

                this.ssn = value;
            }
        }


        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        public string Course
        {
            get
            {
                return this.course;
            }
            set
            {
                this.course = value;
            }
        }


        #endregion

        #region Override Method
        


        public override bool Equals(object param)
        {
            Student student = param as Student;

            if (student == null)
                return false;

            if (!Object.Equals(this.SSN, student.SSN))
                return false;
            if (!Object.Equals(this.FirstName, student.FirstName))
                return false;
            if (!Object.Equals(this.LastName, student.LastName))
                return false;
            return true;
        }


        public static bool operator ==(Student studentFirst, Student studentSecond)
        {
            return Student.Equals(studentFirst, studentSecond);
        }
        public static bool operator !=(Student studentFirst, Student studentSecond)
        {
            return !(Student.Equals(studentFirst, studentSecond));
        }
        public override int GetHashCode()
        {
            return SSN.GetHashCode() ^ FirstName.GetHashCode() ^ LastName.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("SSN: {3} \nName: {0} {1} {2} \nAdress: {4} Telefon: {5} E-mail: {6} \nUniversity: {9} \nFaculty: {10} \nSpecialty: {8} Course: {7}  ",
                this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.MobilePhone, this.Email,
                this.Course, this.SpecialtyStudent, this.UniversityStudent, this.FacultyStudent);
        }

        //Problem 2. ICloneable
        // Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
        public object Clone()
        {
            Student deepCopy = new Student(this.firstName, this.LastName, this.SSN, this.SpecialtyStudent, this.UniversityStudent, this.FacultyStudent,
            this.Course, this.Address, this.MobilePhone, this.Email, this.MiddleName);
            return deepCopy;
        }

     
         //Problem 3. IComparable
         //Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
         //and by social security number (as second criteria, in increasing order).
         

        public int CompareTo(Student otherStudent)
        {
            var StudentName = string.Concat(this.FirstName, this.LastName);
            var otherStudentName = string.Concat(otherStudent.FirstName, otherStudent.LastName);

            var comparisonResult = StudentName.CompareTo(otherStudentName);

            if (comparisonResult == 0)
            {
                return this.SSN.CompareTo(otherStudent.SSN);
            }

            return comparisonResult;
        }

        #endregion
    }
}
