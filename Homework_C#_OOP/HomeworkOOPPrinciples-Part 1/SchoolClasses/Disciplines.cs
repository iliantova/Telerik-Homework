using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Disciplines : ISchool
    {
        public string NameDisciplins { get; private set; }
        private int lecture = 0;
        private int exercises = 0;
      


        public Disciplines(string name, int lecture, int exercises)
        {
            this.NameDisciplins = name;
            this.Lecture = lecture;
            this.Exercises = exercises;

        }

        public int Lecture
        {
            get
            {
                return this.lecture;
            }
            set
            {
                this.lecture = value;
            }
        }

        public int Exercises
        {
            get
            {
                return this.exercises;
            }
            set
            {
                this.exercises = value;
            }
        }
     

        public string GetComment()
        {
            return string.Format("This is a comment to the Discipline objects!");
        }


        public override string ToString()
        {
            return string.Format("Discipline: {0}\nNumber of lectures:{1}\nNumber of exercises:{2}\n", this.NameDisciplins, this.Lecture, this.Exercises);
        }
    }
    }
