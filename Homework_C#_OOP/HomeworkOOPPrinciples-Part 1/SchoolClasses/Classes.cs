using System;
using System.Collections.Generic;
using System.Linq;


namespace SchoolClasses
{
   class Classes: ISchool
    {

       public Guid textIdentifier { get; private set; }
        private  List<Students> studentsInClass ;
        private List<Teachers> teachersForClass;
      
       public Classes(Guid name)
        {
            this.textIdentifier = name;
            this.StudentsInClass = new List<Students>();
            this.TeachersForClass= new List<Teachers>();
            
            
        }

        public List<Students> StudentsInClass
        {
            get
            {
                return this.studentsInClass;
            }
            private set
            {
                studentsInClass = value;
            }
        }
        public List<Teachers> TeachersForClass
        {
            get
            {
                return this.teachersForClass;
            }
            private set
            {
                teachersForClass = value;
            }

        }

             
        public void AddTeacher(Teachers t)
        {
            TeachersForClass.Add(t);
        }

        public void AddStudent(Students s)
        {
            StudentsInClass.Add(s);
        }

        public void RemovePerson(People p)
        {
            if (p is Teachers)
            {
                TeachersForClass.Remove((Teachers)p);
            }
            else
            {
                StudentsInClass.Remove((Students)p);
            }
        }

        public override string ToString()
        {
            return string.Format("Class ID: {0}\n", this.textIdentifier);
        }
        public string GetComment()
        {
            return string.Format("This is a comment to the School class objects!");
        }

    }
}
