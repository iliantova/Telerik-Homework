using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Teachers : People, ISchool
    {
       private List<Disciplines> disciplinesOfTeacher;
      

       public Teachers(string name)
        {
            this.Name = name;
            this.DisciplinesOfTeacher = new List<Disciplines>();
        }

        public List<Disciplines> DisciplinesOfTeacher
        {
            get
            {
                return new List<Disciplines>(disciplinesOfTeacher);
            }
            private set
            {
                disciplinesOfTeacher = value;
            }
        }
       

        public void AddDiscipline(Disciplines d)
        {
            DisciplinesOfTeacher.Add(d);
        }

        public void RemoveDiscipline(Disciplines d)
        {
            DisciplinesOfTeacher.Remove(d);
        }

        public string GetComment()
        {
            return string.Format("This is a comment to the Teacher class!");
        }

        public override string ToString()
        {
            return string.Format("Teacher name: {0}\n",
                this.Name);
        }

        }
}
